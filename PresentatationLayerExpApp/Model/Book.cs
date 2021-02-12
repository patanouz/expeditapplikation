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

        public void AddBooking(Booking booking)
        {
            //Console.WriteLine("Lägger till bokning");

            //Console.WriteLine("Så här många fanns det: " + repo.Count);
            foreach (var item in repo)
            {
                //Console.WriteLine(item.Title);
            }
            repo.Add(booking);
            //Console.WriteLine("Så här många finns det nu: " + repo.Count);
        }

        public bool IsAvailable(DateTime start, DateTime end)
        {
            //TODO: ta bort ifrån listan om den är gammal

            //if(Title == "Hjärnstark") Console.WriteLine("counter " + repo.Count);

            foreach (var item in repo)
            {
                //Kollar om start eller sluttid ligger mellan bokningsperioden
                if ((start < item.ExpiryDate && item.Date < end) && item.Returned == null)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
