using ExpeditApplikation.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpeditApplikation.Model
{
    public class Book
    {
        
        public long ISBN { get; private set; }
        public string Title { get; private set; }
        public int Days { get; private set; }

        private List<Booking> repo;

        internal Book(long isbn, string title)
        {
            repo = new List<Booking>();
            ISBN = isbn;
            Title = title;
            Days = 7;
        }

        /* La till en extra constructor för att välja hur många dagar
         * boken ska vara tillgänglig. 
         * Om det inte anges så är default 7 dagar.
         */
        internal Book(long isbn, string title, int days)
        {
            repo = new List<Booking>();
            ISBN = isbn;
            Title = title;
            Days = days;
        }

        //Vi lägger till aktuella bokningar i boken för att effektivisera processen för att kolla om boken är ledig eller ej.
        public void AddBooking(Booking booking)
        {
            repo.Add(booking);
        }

        //Kollar om boken är ledig från ett specifikt startdatum
        public bool IsAvailable(DateTime start)
        {
            foreach (var item in repo)
            {
                //Kollar om start eller sluttid ligger mellan bokningsperioden
                if ((start < item.ExpiryDate && item.Date < start.AddDays(Days)) && item.Returned == null)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
