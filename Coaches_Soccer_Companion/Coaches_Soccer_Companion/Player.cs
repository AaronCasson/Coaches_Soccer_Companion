using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{
    class Player : Participants
    {
        public List<PositionTime> PlayerPositionTime { get; set; }

        private DateTime dateofbirth;
       // public List<Playtime> playtime;

        //This is called a property.  It is passing in the value from the constructor to the set method.
        public string DateOfBirth
        {
            get { return dateofbirth.ToShortDateString(); }
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
        public Player (string firstname, string lastname, string dateofbirth) : base(firstname, lastname)
        {
            DateOfBirth = dateofbirth;
            this.FirstName = firstname;
            this.LastName = lastname;
        }

    }
}