using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{
    public class Coach : Participants
    {

        public string? phoneNumber { get; set; }

        public Coach(string FirstName, string LastName, string PhoneNumber) : base(FirstName, LastName)
        {

            this.PhoneNumber = PhoneNumber;
        }

    }
}
