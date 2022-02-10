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

        

        public Participants(string aFirstName, string aLastName)
        {
            Guid ParticipantID = Guid.NewGuid();
            firstname = aFirstName;
            lastname = aLastName;
        }

        public Guid ParticipantID
        {
            get { return participantid; }
            set { participantid = value; }
        }

    }
}
