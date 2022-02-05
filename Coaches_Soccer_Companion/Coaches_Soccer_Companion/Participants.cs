using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{
    public class Participants
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ParticipantID { get; private set; }

        public Participants(Guid ParticipantId, FirstName, LastName)
        {
            ParticipantId = Guid.NewGuid();
            this.FirstName = FirstName;
            this.LastName = LastName;
        }



    }
}
