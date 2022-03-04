using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{
    //Here I've created a Participants class to capture basic info (ID, First Name, Last Name) which can be inherited by Coach and Players classes to which it will be relevant.
    class Participants
    {
        public string firstname;

        public string lastname;

        //Here I've demonstrated the use of a Get/Set to allow access to see but not modify a private class (GUID).
        private Guid participantid { get; }

        public Guid ParticipantId
            {
                get {return participantid;}
                set { ; }
            }
        //Here I've demonstrated the use of a constructor which accepts two parameters and also executes a method to genreate an ID upon construction.
        public Participants(string aFirstName, string aLastName)
        {
            participantid = Guid.NewGuid();
            firstname = aFirstName;
            lastname = aLastName;
        }

    }
}
