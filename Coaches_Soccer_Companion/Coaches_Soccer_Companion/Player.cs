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


        //public static List<Player> players;

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
        public Player (string aFirstName, string aLastName, string aDateOfBirth, List<Playtime> playtimes) : base(aFirstName, aLastName)
        {
            DateOfBirth = aDateOfBirth;

        }

        public static void CreateRoster()
        {
            bool addNewPlayer = false;
            int x = 1;
            do
            {
                Playtime playtime = new Playtime();
                Console.WriteLine($"What is the first name of player {x}:");
                string aFirstName = Console.ReadLine();
                Console.WriteLine($"What is the last name of player {x}:");
                string aLastName = Console.ReadLine();
                Console.WriteLine($"What is the birthday of player {x}: (use formate MM/DD/YYYY");
                string aDateOfBirth = Console.ReadLine();
                Console.WriteLine($"What position will player {x} start in during this game:");
                int i = 1;
                foreach (var item in Enum.GetValues(typeof(Position)))
                {
                    Console.WriteLine($"{i}: {item}");
                    i++;
                }
                List<Playtime> playtimes = new List<Playtime>();
                string positionSelection = Console.ReadLine();

                playtime.position = (Position)int.Parse(positionSelection);
                switch (positionSelection)
                {
                    case "1": break;
                    case "2": break;
                    case "3": break;
                    case "4": break;
                    case "5": break;
                    default: Console.WriteLine("You entered an invalid selection, please try again."); break;
                }
                Player player = new Player(aFirstName, aLastName, aDateOfBirth, playtimes);
                players.Add(player);
                x += 1;

                //In this section I use a switch/case method to determine if the loop should repeat.
                Console.WriteLine("Would you like to add another player? (enter yes or no) ");
                string userSelection = Console.ReadLine();
                switch (userSelection)
                {
                    case "yes": addNewPlayer = true; break;
                    case "no": addNewPlayer = false; break;
                    default: Console.WriteLine("You did not enter a correct response."); break;
                }

            }
            while (addNewPlayer == true);
        }

    }
}