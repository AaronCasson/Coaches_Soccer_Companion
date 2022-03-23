using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{
    class Player : Participants
    {
        public List<PositionTime> PlayerPositionTime = new List<PositionTime>();
        public double? totalbenchtime = 0;

        private DateTime dateofbirth;
       // public List<Playtime> playtime;

        //This is called a property.  It is passing in the value from the constructor to the set method.
        public DateTime DateOfBirth
        {
            get { return dateofbirth; }
            set
            {
                try { dateofbirth = value; }
                catch (Exception FormatException) 
                { 
                    Console.WriteLine("Oops, we didn't expect this error with the birthdate you entered, sorry!.");
                }
            }
        }
        public Player (string firstname, string lastname, DateTime dateofbirth) : base(firstname, lastname)
        {
            DateOfBirth = dateofbirth;
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public static Player AddPlayer()
        {
            Console.WriteLine($"What is the first name of player:");
            string playerFirstName = Console.ReadLine();
            Console.WriteLine($"What is the last name of player:");
            string playerLastName = Console.ReadLine();
            DateTime aDateOfBirth;
            bool parseSucceed = false;
            do
            {

                Console.WriteLine($"What is the birthday of player: (use formate MM/DD/YYYY)");
                
                do
                {
                    string playerBirthdate = Console.ReadLine();
                    parseSucceed = DateTime.TryParse(playerBirthdate, out aDateOfBirth);
                    if (!parseSucceed)
                    {
                        Console.WriteLine($"You entered: {playerBirthdate}  This is not a valid format, please try again.");
                    };
                } while (!parseSucceed);
            } while (!parseSucceed);

            Player player = new Player(playerFirstName,playerLastName,aDateOfBirth);
            return player;
        }

    }
}