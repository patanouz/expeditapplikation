using System;
using System.Collections.Generic;

namespace ExpeditApplikation.Internals
{
    /// <summary>
    /// Repository class.
    /// </summary>
    internal class Repository<T>
    {
        internal IList<T> Table {
            get { return table; }
        }

        internal Repository()
        {
            if (table == null) {
                table = new List<T>();
            }
        }

        static IList<T> table;
    }
}
