using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{
    public class Player : Participants
    {

        public DateTimeOffset dateOfBirth { get; set; }

        List<Playtime> playtimes { get; set; } // evertime the play plays you add to this list.

        //create a method called get total playtime that sums items in the list.
        public Player (string PlayerFirstName, string PlayerLastName, DateTime DateOfBirth)
        {
            int iD = Guid.NewGuid()
            this.PlayerFirstName = FirstName;
            this.PlayerLastName = lastName;
            this.dateOfBirth = dateOfBirth; 

        }
        public enum Position
        {
            GoalKeeper,
            FullBack,
            MidFielder,
            Forward
        }

    }
}
