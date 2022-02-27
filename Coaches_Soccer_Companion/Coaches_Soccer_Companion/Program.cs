namespace Coaches_Soccer_Companion
{
    class Program
    {
        private static List<Player> players = new List<Player>();
        public static void Main(string[] args)
        {
    
            Console.WriteLine("   ___  ___    __  ___  |  |  ");
            Console.WriteLine("   |   |   |  |__| |    |__|  ");
            Console.WriteLine("   |__ |___|  |  | |__  |  |  ");
         

            //this employs a foreach loop to print out a welcome message.
            string welcome = "Hi Coach!  This application will help you keep track of the time your players are getting on the field, but before we start lets get you registered.";
            foreach (char c in welcome)
            {
                Console.Write(c);
                Thread.Sleep(50);
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

            Console.WriteLine("Now can you tell us who showed up to the game today?");


            //In this section of code I've leverage a do/while loop to capture the player info.
            bool addNewPlayer = false;
            int x = 1;
            do
            {
                Console.WriteLine($"What is the first name of player {x}:");
                string aFirstName = Console.ReadLine();
                Console.WriteLine($"What is the last name of player {x}:");
                string aLastName = Console.ReadLine();
                Console.WriteLine($"What is the birthday of player {x}: (use formate MM/DD/YYYY");
                string aDateOfBirth = Console.ReadLine();
                Player player = new Player(aFirstName, aLastName, aDateOfBirth);
                players.Add(player);
                x += 1;

                //In this section I use a switch/case method to determine if the loop should repeat.
                Console.WriteLine("Would you like to add another player? (enter yes or no) ");
                string userSelection = Console.ReadLine();
                switch (userSelection)
                {
                    case "yes": addNewPlayer = true; break;
                    case "no": addNewPlayer = false; break;
                }

            }
            while (addNewPlayer == true);



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