using ExpeditApplikation.Internals;
using ExpeditApplikation.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpeditApplikation
{
    /// <summary>
    ///  This is the facade of the business layer.
    /// </summary>
    public class BookingSystem
    {
        private int BookingRefIncrement;
        private string userID;
        private static BookingSystem bs;

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
            if (bs == null)
            {
                bs = new BookingSystem();
            }
            return bs;
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



        public IList<Book> AvailableBooks()
        {
            
            List<Book> availableBooks = new List<Book>();
            foreach (Book book in data.BookRepository.Table)
            {
                if (book.Available == true)
                    availableBooks.Add(book);

            }
            return availableBooks;
        }

        public IList<Book> AllBooks()
        {
            return data.BookRepository.Table;
        }

        public IList<Booking> ExistingBookings()
        {
            
            return data.BookingRepository.Table;
        }

        public IList<Booking> NonReturnedBookings()
        {
            List<Booking> bookings = new List<Booking>();
            foreach (Booking booking in data.BookingRepository.Table)
            {
                if(!booking.returned)
                {
                    bookings.Add(booking);
                }
            }
            return bookings;
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

            foreach(Booking bk in data.BookingRepository.Table)
            {
                if(bk.BookingReference == bookingId)
                {
                    bk.returned = true;
                    Book b = FindBook("" + bk.ISBN);
                    b.Available = true;
                }
            }
            //TODO: faktura osv, men orkar inte ta det när jag inte kan testa det.
            //Behöver fixa om datetime.now och adddays först, annars måste jag vänta 
            //7 dagar på att se om det funkar.
        }

        /* Lägger till en metod för att söka bok på ID, behöver den
         * För tillfället behöver jag den endast i metoden AddBooking 
         * men den kanske behövs senare också.
         */
        public Book FindBook(string isbn)
        {

            /* Kollar så att isbn ej innehåller bokstäver, det pajjar int.Parse
             * Vill inte köra en tryparse. Onödigt att göra detta egentligen
             * men man ska helst undvika try/catch om det går. try/catch
             * är väldigt oeffektivt.
             */
            if (!isbn.All(c => c >= '0' && c <= '9'))
            {
                return null;
            }


            foreach (Book b in data.BookRepository.Table)
            {
                if (b.ISBN.Equals(long.Parse(isbn)))
                {
                    return b;
                }
            }
            return null;
        }


        public void AddBooking(string memberId, Book book)
        {


            //Eftersom FindBook kan returnera null så hanterar jag null som ett fel
            if (book == null)
            {
                //TODO: behöver kolla om det behöver indikeras för användaren.
                //Tror inte denna if-satsen ens behövs.
                return;
            }

            DateTime loanTime = DateTime.Now;

            /* Hämtar dagar från bok.
             * Tänkte skriva om denna lite för att använda sekunder istället
             * men endast om den testas med testkonto, eller något.
             * 
             * Jag orkar inte vänta 7 dagar på att ta reda på om koden funkar,
             * gör ni?
             * 
             * Gör det senare.
             * TODO: Fix.
             */
            loanTime = loanTime.AddDays(book.Days);

            Console.WriteLine("Now: " + DateTime.Now + "\nExpiry: " + loanTime);
            data.BookingRepository.Table.Add(new Booking(
                "B" + Convert.ToString(BookingRefIncrement++),
                userID,
                book.Title,
                memberId,
                Convert.ToInt64(book.ISBN),
                DateTime.Now,
                loanTime
           ));

            book.Available = false;

            //Detta behövs ej längre.
            /*foreach(Book boo in data.BookRepository.Table){
                if (Convert.ToString(boo.ISBN) == isbn)
                    boo.Available = false;
            }
            */
        }

        private Internals.Data data;
    }
}
