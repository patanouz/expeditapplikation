using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpeditApplikation.Model
{
    class Member
    {
        public string MemberID
        {
            get; private set;
        }

        public string FirstName
        {
            get; private set;
        }

        public string LastName
        {
            get; private set;
        }

        public string TeleNo
        {
            get; private set;
        }

        public string Email
        {
            get; private set;
        }

        internal Internals.Data Data
        {
            get => default;
            set
            {
            }
        }

        internal Member(string id, string firstname, string lastname, string tele, string email)
        {
            MemberID = id;
            FirstName = firstname;
            LastName = lastname;
            TeleNo = tele;
            Email = email;
        }
    }
}
