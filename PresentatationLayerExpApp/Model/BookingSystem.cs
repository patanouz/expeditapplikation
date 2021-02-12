using ExpeditApplikation.Internals;
using ExpeditApplikation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpeditApplikation
{
    /// <summary>
    ///  This is the facade of the business layer.
    /// </summary>
    public class BookingSystem
    {
        private int BookingRefIncrement;
        private string userID;
        private static BookingSystem bookingSystem;

        public User LoggedIn
        {
            get; private set;
        }

        public BookingSystem()
        {
            BookingRefIncrement = 0;
            data = new Data();
        }

        public static BookingSystem GetBs()
        {
            if (bookingSystem == null)
            {
                bookingSystem = new BookingSystem();
            }
            return bookingSystem;
        }

        /// <summary>
        ///  The LogIn system operation.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string LogIn(string userId, string password)
        {
            foreach (User user in data.UserRepository.Table)
            {
                if (user.UserID == userId && user.VerifyPassword(password))
                {
                    LoggedIn = user;
                    userID = userId;
                    return user.Role;
                }
            }
            return "false";
        }

        public IList<Book> AvailableBooks(DateTime date)
        {           
            List<Book> availableBooks = new List<Book>();
            foreach (Book book in data.BookRepository.Table)
            {
                availableBooks.Add(book);
                if (!IsAvailable(book, date))
                    availableBooks.Remove(book);
            }
            return availableBooks;
        }

        public bool IsAvailable(Book book, DateTime date)
        {
            //kollar om boken är ledig mellan datum och datum + antal dagar man får lov att låna boken.
            return book.IsAvailable(date, date.AddDays(book.Days));


            //TODO: Byt ut.
            /*foreach (Booking booking in data.BookingRepository.Table)
            {
                if (booking.ISBN == book.ISBN && date >= booking.Date && date <= booking.ExpiryDate)
                {
                    if(booking.Returned == null || booking.Returned > date)
                        return false;
                }
            }
            return true;
            */
        }

        public IList<Book> AllBooks()
        {
            return data.BookRepository.Table;
        }

        public IList<Booking> AllBookings()
        {
            return data.BookingRepository.Table;
        }

        public IList<Booking> ExistingBookings()
        {
            IList<Booking> currentBookings = new List<Booking>();

            foreach (Booking booking in data.BookingRepository.Table)
            {
                if (booking.Returned == null)
                    currentBookings.Add(booking);
            }
            return currentBookings;
        }

        public string bookingStatus(Booking booking)
        {
            if (booking.Returned == null)
            {
                if (booking.ExpiryDate > DateTime.Now)
                    return "active";
                else
                    return "delayed";
            }
            else
            {
                if (booking.OustandingPayment <= 0)
                    return "paid";
                else
                    return "pending";
            }
        }

        public bool IsMember(string memberID)
        {
            foreach (Member member in data.MemberRepository.Table)
            {
                if (member.MemberID == memberID)
                    return true;
            }
            return false;
        }

        public void ReturnBook(string bookingId)
        {
            foreach(Booking booking in data.BookingRepository.Table)
            {
                if(booking.BookingReference == bookingId)
                {
                    try
                    {
                        int index = FindBooking(bookingId);

                        data.BookingRepository.Table[index].Returned = DateTime.Now;
                        if (booking.ExpiryDate < booking.Returned)
                        {
                            booking.OustandingPayment = Math.Ceiling((DateTime.Now - booking.ExpiryDate).TotalDays) * 10;
                        }
                    }
                    catch (ArgumentException)
                    {
                        throw new ArgumentException("Argument does not exist within BookRepository");
                    }
                }
            }
        }
        public int FindBooking(string bookingRef)
        {
            for (int i = 0; i < data.BookingRepository.Table.Count; i++)
            {
                if (data.BookingRepository.Table[i].BookingReference.Equals(bookingRef))
                {
                    return i;
                }
            }
            throw new ArgumentException("Argument does not exist within BookRepository");
        }

        public Book FindBook(long isbn)
        {
            foreach (var book in data.BookRepository.Table)
            {
                if (book.ISBN == isbn) return book;
            }
            return null;
        }

        public void AddBooking(string memberId, Book book, DateTime date)
        {
            //Eftersom FindBook kan returnera null så hanterar jag null som ett fel
            if (book == null)
            {
                return;
            }

            DateTime loanTime = date;
            loanTime = loanTime.AddDays(book.Days);

            //Console.WriteLine("Now: " + date + "\nExpiry: " + loanTime);

            Booking booking = new Booking(
                "B" + Convert.ToString(BookingRefIncrement++),
                userID,
                book.Title,
                memberId,
                Convert.ToInt64(book.ISBN),
                date,
                loanTime
           );
            data.BookingRepository.Table.Add(booking);
            book.AddBooking(booking);
        }

        private Internals.Data data;

        internal Data Data
        {
            get => default;
            set
            {
            }
        }

        public Booking Booking
        {
            get => default;
            set
            {
            }
        }

        public User User
        {
            get => default;
            set
            {
            }
        }

        public Book Book
        {
            get => default;
            set
            {
            }
        }

        internal Member Member
        {
            get => default;
            set
            {
            }
        }
    }
}
