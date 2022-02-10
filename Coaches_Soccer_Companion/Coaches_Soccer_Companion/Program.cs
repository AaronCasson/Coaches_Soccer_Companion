namespace Coaches_Soccer_Companion
{
    class Program
    {
        public static void Main(string[] args)
        {
            Coach aaron = new Coach("555-555-5555", "Aaron", "Casson");
            aaron.SayMyName(100);
            Console.ReadLine();
        }
    }

}