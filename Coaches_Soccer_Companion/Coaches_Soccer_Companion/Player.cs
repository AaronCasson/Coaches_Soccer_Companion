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
                catch (Exception FormatException) 
                { 
                    Console.WriteLine("Invalid birthday format!");
                    
                    Console.WriteLine("Try entering the value again, remember it needs to be MM/DD/YYYY:");

                }
            }
        }
        

        //create a method called get total playtime that sums items in the list.
        public Player (string aFirstName, string aLastName, string aDateOfBirth) : base(aFirstName, aLastName)
        {
            DateOfBirth = aDateOfBirth; 
        }

        public static DateTime playtimestart;
        public static DateTime playtimeend;

        public double TimePlayed(DateTime playtimestart, DateTime playtimeend)
        {
            TimeSpan playtime = playtimeend.Subtract(playtimestart);
            return playtime.TotalSeconds;
        }

        public List<double> TotalTimePlayed = new List<double>();

        //public TimeSpan TotalTimePlayed2 = new TimeSpan(0);
            
        /*public TimeSpan TimePlayed2(DateTime playtimestart, DateTime playtimeend)
        {
            TotalTimePlayed2 += playtimeend.Subtract(playtimestart);
            return TotalTimePlayed2;
        }*/


        public enum Position
        {
            GoalKeeper,
            FullBack,
            MidFielder,
            Forward
        }

    }
}