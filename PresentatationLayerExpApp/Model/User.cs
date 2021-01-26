using System;
using System.Collections.Generic;
using System.Text;

namespace ExpeditApplikation.Model
{
    public class User
    {
        public int UserID
        {
            get; private set;
        }

        public string Name
        {
            get; private set;
        }

        internal User(int id, string password, string name)
        {
            UserID = id;
            this.password = password;
            Name = name;
        }

        internal bool VerifyPassword(string inputpassword)
        {
            return password == inputpassword;
        }

        private string password;
    }
}
