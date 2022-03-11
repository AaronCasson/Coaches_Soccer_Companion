using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{
    //Here I've demonstrated inheritance of the Participants Class
    class Coach : Participants
    {

        public string phonenumber;

        public Coach(string aPhoneNumber, string aFirstName, string aLastName) : base(aFirstName, aLastName)
        {
            phonenumber = aPhoneNumber;
        }
        public void DisplayCoach()
        {
            Console.WriteLine($"Name: {firstname} {lastname} GUID: {ParticipantId} Phone Number: {phonenumber}");
        }

        public static void RegisterCoach()
        {
            //this section uses console read line to collect coach info.
            Console.WriteLine("Please enter your first name:");
            string coachFirstName = Console.ReadLine();

            Console.WriteLine("Cool, thanks!  Now enter your last name:");
            string coachLastName = Console.ReadLine();

            Console.WriteLine("One last thing... please enter your phone number in the format 555-555-5555");
            string coachPhoneNumber = Console.ReadLine();

            //This uses the coach class to create new instance of coach
            Coach coach = new Coach(coachFirstName, coachLastName, coachPhoneNumber);
        }
    }
}
