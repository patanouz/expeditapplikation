using System;
using System.Collections.Generic;
using System.Text;

namespace ExpeditApplikation.Model
{
    public class Booking
    {
        public string BookingReference { get; private set; }
        public string UserID { get; private set; }

        /* Jag sparar titel här för att kunna se det i bokning
         * kändes lättare så än att behöva loopa igenom lista av alla
         * böcker för VARJE bokning.
         */
        public string Title { get; private set; }
        public string MemberID { get; private set; }
        public long ISBN { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime ExpiryDate { get; private set; }
        public DateTime? Returned { get; set; }
        public double OustandingPayment { get; set; }

        //Jag tar inte bort några bokningar, gör dom bara inaktiva.

        internal Booking(string bookingRef, string userId, string title, string memberId, long isbn, DateTime startDate, DateTime expiryDate)
        {
            BookingReference = bookingRef;
            UserID = userId;
            Title = title;
            MemberID = memberId;
            ISBN = isbn;
            Date = startDate;
            ExpiryDate = expiryDate;
            Returned = null;
            OustandingPayment = 0;
        }
    }
}
