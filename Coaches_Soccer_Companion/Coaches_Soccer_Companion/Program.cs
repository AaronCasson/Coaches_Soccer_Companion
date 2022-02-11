namespace Coaches_Soccer_Companion
{
    class Program
    {
        public static void Main(string[] args)
        {
            Coach aaron = new Coach("555-555-5555", "Aaron", "Casson");
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
            Console.ReadLine();

        }
    }

}