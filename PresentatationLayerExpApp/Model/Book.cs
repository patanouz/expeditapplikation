using System;
using System.Collections.Generic;
using System.Text;

namespace ExpeditApplikation.Model
{
    public class Book
    {
        public long ISBN {
            get; private set;
        }

        public string Title{
            get; private set;
        }

        public bool Available
        {
            get; set;
        }

        public int Days
        {
            get; private set;
        }

        internal Book(long isbn, string title){
            ISBN = isbn;
            Title = title;
            Available = true;
            Days = 7;

        }

        /* La till en extra constructor för att välja hur många dagar
         * boken ska vara tillgänglig. 
         * Om det inte anges så är default 7 dagar.
         */
        internal Book(long isbn, string title, int days)
        {
            ISBN = isbn;
            Title = title;
            Days = days;
            Available = true;

        }
    }
}
