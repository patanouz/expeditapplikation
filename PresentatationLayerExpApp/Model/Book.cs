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

        internal Book(long isbn, string title){
            ISBN = isbn;
            Title = title;
            Available = true;
        }
    }
}
