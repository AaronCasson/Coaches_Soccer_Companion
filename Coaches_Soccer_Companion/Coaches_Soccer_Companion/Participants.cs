using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{
    class Participants
    {
        public string firstname;

        public string lastname;

        private Guid participantid;

        public Guid ParticipantId
        {
            get { return participantid; }
            set { ; }
        }

        

        public Participants(string aFirstName, string aLastName)
        {
            participantid = Guid.NewGuid();
            firstname = aFirstName;
            lastname = aLastName;
        }

    }
}
