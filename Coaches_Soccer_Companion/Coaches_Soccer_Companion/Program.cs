namespace Coaches_Soccer_Companion
{
    class Program
    {
        public static Team team = new Team();
        public static List<Player> players = new List<Player>();
        
        public static void Main(string[] args)
        {

            Console.WriteLine("   ___  ___    __  ___  |  |  ");
            Console.WriteLine("   |   |   |  |__| |    |__|  ");
            Console.WriteLine("   |__ |___|  |  | |__  |  |  ");
            Console.WriteLine("                              ");


            //this employs a foreach loop to print out a welcome message.
            Console.WriteLine("");
            string welcome = "Hi Coach!  This application will help you keep track of the time your players are getting on the field.";
            foreach (char c in welcome)
            {
                Console.Write(c);
                Thread.Sleep(25);
            }
            Console.WriteLine("");
            Console.WriteLine("What is the name of your team?");
            team.TeamName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Lets get you registered as a coach.");
            team.Coach = Coach.AddCoach();
            Console.WriteLine("");
            Console.WriteLine($"{team.Coach.FirstName} {team.Coach.LastName} is now the coach of {team.TeamName}");
            Console.WriteLine("");

            team.Players = players;

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

            Console.WriteLine("");
            Console.WriteLine("Now its time to start the match!  First We need to assign the players to positions.");
            Console.WriteLine("");

            bool endmatch = false;
            int timeperiod = 0;
            do
            {
                
                for (int index = 0; index < players.Count; index++)
                {
                    PositionTime positiontime = new PositionTime();
                    players[index].PlayerPositionTime.Add(positiontime);
                    Console.WriteLine($"What position will {players[index].FirstName} {players[index].LastName} play in?");

                    int i = 1;
                    foreach (var item in Enum.GetValues(typeof(Position)))
                    {
                        Console.WriteLine($"{i}: {item}");
                        i++;
                    }

                    string positionSelection = Console.ReadLine();
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
                    
                    
                    positiontime.Position = (Position)(int.Parse(positionSelection) - 1);

                }


                Console.WriteLine("Press enter when the match starts.");
                Console.ReadLine();
                DateTime PlaytimeStart = DateTime.Now;
                Console.WriteLine("Press enter when the match pauses or ends.");
                Console.ReadLine();
                DateTime PlaytimeEnd = DateTime.Now;
                double TimePlayed = PositionTime.TimePlayedCalc(PlaytimeStart, PlaytimeEnd);
                for (int i = 0; i < players.Count; i++)
                {
                    players[i].PlayerPositionTime[timeperiod].TimePlayed = TimePlayed;
                }

                Console.WriteLine("Playtime Stats to date:");
                
                for (int index = 0; index < players.Count; index++)
                {
                    int i = 1;
                    Console.WriteLine(String.Format("{0} {1} {2}", players[index].FirstName, players[index].LastName, players[index].DateOfBirth + ":"));
                    foreach (PositionTime p in players[index].PlayerPositionTime)
                    {
                        
                        Console.WriteLine($"Timeperiod {i}: {p.Position} {p.TimePlayed}");
                        i++;
                    }
                }
                Console.WriteLine("Pess enter to continue.");
                Console.ReadLine();

                Console.WriteLine("Would you like to continue the game? (enter yes or no) ");
                string userSelection = Console.ReadLine();
                switch (userSelection)
                {
                    case "yes": endmatch = false; break;
                    case "no": endmatch = true; break;
                    default: Console.WriteLine("You did not enter a correct response."); break;
                }
                timeperiod++;
            }
            while (endmatch == false);

        }
    }
}