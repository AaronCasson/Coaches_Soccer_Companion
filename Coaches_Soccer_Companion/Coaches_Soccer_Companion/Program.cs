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

            Console.WriteLine("What would you like to do first:");
            Console.WriteLine("1: Register A Coach");
            Console.WriteLine("2: Create A Player Roster For The Game");
            Console.WriteLine("3: Start the Match");

            string userselection = Console.ReadLine();
            switch(userselection)
            {
                case "1": Coach.RegisterCoach(); break;
                case "2": Player.CreateRoster(); break;
            }
            



            Console.WriteLine("Now can you tell us who showed up to the game today?");


            //In this section of code I've leverage a do/while loop to capture the player info.
            



            Console.WriteLine("In this period here is what your players did:");
            for (int index = 0; index < players.Count; index++)
            {
                Console.WriteLine(players[index].firstname + " " + players[index].lastname + " " + players[index].position[index] + " " + players[index].playtimes[index]);
            }
            Console.ReadLine();

            /*            Console.WriteLine("Choose an action:");
                        string userSelection = Console.ReadLine();
                        switch(userSelection)
                        {
                            case "1": StartMatch():
                            case "2": AddPlayer():
                            case "3: ModifyPlayer():

                        }*/

            /*            Coach aaron = new Coach("555-555-5555", "Aaron", "Casson");
                        aaron.SayMyName(100);
                        Console.ReadLine();

                        Player ryan = new Player("Ryan", "Casson", "2011-07-11");
                        Console.WriteLine(ryan.DateOfBirth);
                        Console.ReadLine();

                        DateTime x = DateTime.Now;
                        Console.ReadLine();
                        DateTime y = DateTime.Now;
                        Console.ReadLine();



                        Console.WriteLine(ryan.TimePlayed(x, y));
                       // Console.WriteLine("TimePlayed2: " + ryan.TimePlayed2(x, y));
                        Console.ReadLine();

                        Double playtime1 = ryan.TimePlayed(x, y);
                        Console.WriteLine(playtime1);
                        Console.ReadLine();

                        DateTime a = DateTime.Now;
                        Console.ReadLine();
                        DateTime b = DateTime.Now;
                        Console.ReadLine();

                        Console.WriteLine(ryan.TimePlayed(a, b));
                       // Console.WriteLine("TimePlayed2: " + ryan.TimePlayed2(a, b));
                        Console.ReadLine();


                        Double playtime2 = ryan.TimePlayed(a, b);
                        Console.WriteLine(playtime2);
                        Console.ReadLine();

                        ryan.TotalTimePlayed.Add(playtime1);
                        ryan.TotalTimePlayed.Add(playtime2);
                        Console.WriteLine(ryan.TotalTimePlayed.Sum());

                        Console.ReadLine();*/

        }
    }

}