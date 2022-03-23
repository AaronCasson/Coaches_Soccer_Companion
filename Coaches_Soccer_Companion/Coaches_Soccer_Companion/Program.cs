namespace Coaches_Soccer_Companion
{
    class Program
    {
        
        
        public static void Main(string[] args)
        {
            bool quitApplication = false;
            do
            {

                Console.WriteLine("                                    ");
                Console.WriteLine("   ___  ___    __  ___  |  | ' ___  ");
                Console.WriteLine("   |   |   |  |__| |    |__|   |__  ");
                Console.WriteLine("   |__ |___|  |  | |__  |  |   __|  ");
                Console.WriteLine("                                    ");
                Console.WriteLine("           Soccer Companion         ");
                Console.WriteLine("                                    ");
                Console.WriteLine("         An app by: Aaron Casson    ");


                //this employs a foreach loop to print out a welcome message.
                Console.WriteLine("");
                string welcome = "Hi Coach!  This application will help you keep track of the time your players are getting on the field.";
                foreach (char c in welcome)
                {
                    Console.Write(c);
                    Thread.Sleep(25);
                }
                Team team = new Team();
                List<Player> players = new List<Player>();

                //in this section the user creates a team by giving the team a Name, Coach, and Players.
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

                //in this section the team roster is created using the AddPlayer() method from the Players class.
                bool addNewPlayer = false;
                int x = 1;
                do
                {
                    Console.WriteLine($"Register Player {x}:");

                    players.Add(Player.AddPlayer());
                    x += 1;

                    //In this section I use a switch/case method to determine if the loop should repeat.
                    bool isValid = true;
                    do {
                        Console.WriteLine("Would you like to add another player? (enter yes or no) ");
                        string userSelection = Console.ReadLine();
                        switch (userSelection)
                        {

                            case "yes": addNewPlayer = true; isValid = true; break;
                            case "no": addNewPlayer = false; isValid = true; break;
                            default: Console.WriteLine("You did not enter a correct response. Try again."); isValid = false; break;
                        } 
                    } while (!isValid);
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

                        bool isValid = true;
                        do {
                            string positionSelection = Console.ReadLine();
                            switch (positionSelection)
                            {
                                case "1": isValid = true; break;
                                case "2": isValid = true; break;
                                case "3": isValid = true; break;
                                case "4": isValid = true; break;
                                case "5": isValid = true; break;
                                default:
                                    Console.WriteLine("You entered an invalid selection, please try again."); isValid = false; break;
                            }
                        positiontime.Position = (Position)(int.Parse(positionSelection) - 1);
                        } while (!isValid);

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
                        if (players[i].PlayerPositionTime[timeperiod].Position == Position.Bench)
                        {
                            players[i].totalbenchtime += TimePlayed;
                        }

                    }

                    Console.WriteLine("Consider subbing in the player at the top of the list!  They have been on the bench the longest:");
                    IEnumerable<Player> query = players.OrderByDescending(players => players.totalbenchtime);
                    foreach (Player player in query)
                    {

                        Console.WriteLine("{0} - {1} seconds", player.FirstName, player.totalbenchtime);
                    }



                    Console.WriteLine("Pess enter to continue.");

                    Console.ReadLine();
                    bool isValid2 = true;
                    do {
                        Console.WriteLine("Would you like to continue the game? (enter yes or no) ");
                        string userSelection = Console.ReadLine();
                        switch (userSelection)
                        {
                            case "yes": endmatch = false; isValid2 = true; break;
                            case "no": endmatch = true; isValid2 = true; break;
                            default: Console.WriteLine("You did not enter a correct response."); isValid2 = false; break;
                        }
                    }while(!isValid2);

                    timeperiod++;
                }
                while (endmatch == false);
                Console.WriteLine("");
                Console.WriteLine("Match Summary:");

                for (int index = 0; index < players.Count; index++)
                {
                    int i = 1;
                    Console.WriteLine(String.Format("{0} {1} {2}", players[index].FirstName, players[index].LastName, players[index].DateOfBirth.ToShortDateString() + ":"));
                    foreach (PositionTime p in players[index].PlayerPositionTime)
                    {

                        Console.WriteLine($"Timeperiod {i}: {p.Position} {p.TimePlayed}");
                        i++;
                    }
                    Console.WriteLine("");
                }
                bool isValid3 = true;
                do
                {
                    Console.WriteLine("What would you like to do next?\n1: Start new match.\n2: Quit application.");
                    string applicationSelection = Console.ReadLine();
                    switch (applicationSelection)
                    {
                        case "1": quitApplication = false; isValid3 = true; break;
                        case "2": quitApplication = true; isValid3 = true;  break;
                        default: Console.WriteLine("You did not enter a correct response."); isValid3 = false; break;
                    }
                }while (!isValid3);
                
            } while (!quitApplication);

            Console.WriteLine($"Thanks for using the application!");
            

        }
    }
}