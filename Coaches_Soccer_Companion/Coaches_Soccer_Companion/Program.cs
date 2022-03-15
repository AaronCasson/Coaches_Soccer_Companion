namespace Coaches_Soccer_Companion
{
    class Program
    {

        public static List<Player> players = new List<Player>();
        public static void Main(string[] args)
        {

            Console.WriteLine("   ___  ___    __  ___  |  |  ");
            Console.WriteLine("   |   |   |  |__| |    |__|  ");
            Console.WriteLine("   |__ |___|  |  | |__  |  |  ");
            Console.WriteLine("                              ");


            //this employs a foreach loop to print out a welcome message.
            string welcome = "Hi Coach!  This application will help you keep track of the time your players are getting on the field.";
            foreach (char c in welcome)
            {
                Console.Write(c);
                Thread.Sleep(25);
            }
            //this section uses console read line to collect coach info.
            Console.WriteLine("Please enter your first name:");
            string coachFirstName = Console.ReadLine();

            Console.WriteLine("Cool, thanks!  Now enter your last name:");
            string coachLastName = Console.ReadLine();

            Console.WriteLine("One last thing... please enter your phone number in the format 555-555-5555");
            string coachPhoneNumber = Console.ReadLine();

            //This uses the coach class to create new instance of coach
            Coach coach = new Coach(coachFirstName, coachLastName, coachPhoneNumber);

            bool addNewPlayer = false;
            int x = 1;
            do
            {

                Console.WriteLine($"What is the first name of player {x}:");
                string playerFirstName = Console.ReadLine();
                Console.WriteLine($"What is the last name of player {x}:");
                string playerLastName = Console.ReadLine();
                Console.WriteLine($"What is the birthday of player {x}: (use formate MM/DD/YYYY");
                string aDateOfBirth = Console.ReadLine();

                players.Add(new Player(playerFirstName, playerLastName, aDateOfBirth));
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

                for (int index = 0; index < players.Count; index++)
                {
                PositionTime positiontime = new PositionTime();
                Console.WriteLine($"What position will {players[index].FirstName} {players[index].LastName} play in?");

                    int i = 1;
                    foreach (var item in Enum.GetValues(typeof(Position)))
                    {
                        Console.WriteLine($"{i}: {item}");
                        i++;
                    }
                    string positionSelection = Console.ReadLine();
                    positiontime.Position = (Position)(int.Parse(positionSelection)-1);
                    switch (positionSelection)
                    {
                        case "1": break;
                        case "2": break;
                        case "3": break;
                        case "4": break;
                        case "5": break;
                        default:
                            Console.WriteLine("You entered an invalid selection, please try again."); break;
                    }
                players[index].PlayerPositionTime.Add(positiontime);
                }

                for (int index = 0; index < players.Count; index++)
            {
                Console.WriteLine(String.Format("{0} {1} {2}", players[index].FirstName, players[index].LastName, players[index].DateOfBirth));
                foreach(PositionTime p in players[index].PlayerPositionTime)
                {
                    Console.WriteLine(p.Position);
                }
            }
                Console.ReadLine();

        }
    }
}