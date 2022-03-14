using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{
    //Here I've demonstrated inheritance of the Participants Class
    class Coach : Participants
    {

        public string phonenumber;

        public Coach(string firstname, string lastname, string phonenumber) : base(firstname, lastname)
        {
            this.phonenumber = phonenumber;
            this.FirstName = firstname;
            this.LastName = lastname;
            //research default constructor in C#... do I need this???
        }


    }
}
