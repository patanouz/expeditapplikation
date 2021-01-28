using System;
using System.Collections.Generic;
using System.Text;

namespace ExpeditApplikation.Model
{
    public class User
    {
        public string UserID
        {
            get; private set;
        }

        public string Name
        {
            get; private set;
        }
        public string Role
        {
            get; private set;
        }


        internal User(string id, string password, string name, string role)
        {
            UserID = id;
            this.password = password;
            Name = name;
            Role = role;
        }

        internal bool VerifyPassword(string inputpassword)
        {
            return password == inputpassword;
        }

        private string password;
    }
}
