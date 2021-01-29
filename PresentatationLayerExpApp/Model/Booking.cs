using System;
using System.Collections.Generic;
using System.Text;

namespace ExpeditApplikation.Model
{
    public class Booking
    {
        public string BookingReference
        {
            get; private set;
        }

        public string UserID
        {
            get; private set;
        }

        public string MemberID
        {
            get; private set;
        }

        public long ISBN
        {
            get; private set;
        }
        public DateTime Date
        {
            get; private set;
        }
        public DateTime ExpiryDate
        {
            get; private set;
        }

        internal Booking(string bookingRef, string userId, string memberId, long isbn, DateTime startDate, DateTime expiryDate)
        {
            BookingReference = bookingRef;
            UserID = userId;
            MemberID = memberId;
            ISBN = isbn;
            Date = startDate;
            ExpiryDate = expiryDate;
        }
    }
}
