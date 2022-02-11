using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{
    class Player : Participants
    {

        private DateTime dateofbirth;

        public string DateOfBirth
        {
            get { return dateofbirth.ToString(); }
            set
            {
                try { dateofbirth = DateTime.Parse(value); }
                catch (Exception FormatException) { Console.WriteLine("Invalid birthday format!"); }
            }
        }
        List<double> playtimelist { get; set; } // evertime the play plays you add to this list.

        //create a method called get total playtime that sums items in the list.
        public Player (string aFirstName, string aLastName, string aDateOfBirth) : base(aFirstName, aLastName)
        {
            DateOfBirth = aDateOfBirth; 
        }

        public static DateTime playtimestart;
        public static DateTime playtimeend;

        public double TimePlayed(DateTime playtimestart, DateTime playtimeend)
        {
            TimeSpan x = playtimeend.Subtract(playtimestart);
            return x.TotalSeconds;
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