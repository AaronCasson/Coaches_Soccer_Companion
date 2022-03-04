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

        List<Playtime> playtimes;
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
        public Player (string aFirstName, string aLastName, string aDateOfBirth, List<Playtime.Position> position) : base(aFirstName, aLastName)
        {
            DateOfBirth = aDateOfBirth;
            playtimes = new List<Playtime>();
        }


        

/*        public string AssignPosition(enum Position)
        {

        }*/

    }
}