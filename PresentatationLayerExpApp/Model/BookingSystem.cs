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

        public User LoggedIn {
            get; private set;
        }

        public BookingSystem()
        {
            BookingRefIncrement = 0;
            data = new Data();
        }

        public static BookingSystem GetBs()
        {
            if(bs == null)
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
            foreach (User user in data.UserRepository.Table) {
                if (user.UserID == userId && user.VerifyPassword(password)) {
                    LoggedIn = user;
                    userID = userId;
                    return user.Role;
                }
            }
            return "false";
        }



        public IList<Book> AvailableBooks()
        {
            data = new Data();
            List<Book> availableBooks = new List<Book>();
            foreach (Book book in data.BookRepository.Table)
            {
                if (book.Available == true)
                    availableBooks.Add(book);

            }
            return availableBooks;
        }

        public IList<Booking> ExistingBookings()
        {
            List<Booking> bookings = new List<Booking>();
            foreach (Booking booking in data.BookingRepository.Table)
            {
                bookings.Add(booking);
            }
            return bookings;
        }

        public bool IsMember(string memberID)
        {
            foreach(Member member in data.MemberRepository.Table)
            {
                if (member.MemberID == memberID)
                    return true;
            }
            return false;
        }
        public void AddBooking(string memberId, string isbn)
        {
            data.BookingRepository.Table.Add(new Booking(
                Convert.ToString(BookingRefIncrement++),
                userID,
                memberId,
                (long) Convert.ToInt32(isbn),
                DateTime.Now,
                DateTime.Now
           ));
           foreach(Book book in data.BookRepository.Table){
                if (Convert.ToString(book.ISBN) == isbn)
                    book.Available = false;
            }
        }

        private Internals.Data data;
    }
}
