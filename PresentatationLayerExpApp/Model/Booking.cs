using System;
using System.Collections.Generic;
using System.Text;

namespace ExpeditApplikation.Model
{
    public class Booking
    {
        public long BookingReference
        {
            get; private set;
        }

        public int EmployeeID
        {
            get; private set;
        }

        public int MemberID
        {
            get; private set;
        }

        public int ISBN
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
    }
}
