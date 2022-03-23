using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{
    //Here I've demonstrated inheritance of the Participants Class
    class Coach : Participants
    {

        public string phonenumber;

        //Here the coach constructor must contain inherited members of the base constructor.
        public Coach(string firstname, string lastname, string phonenumber) : base(firstname, lastname)
        {
            this.phonenumber = phonenumber;
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        const string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
        public static bool IsPhoneNumber(string testnumber)
        {
            if (testnumber != null)
                return Regex.IsMatch(testnumber, motif);
            else return false;
        }
        public static Coach AddCoach()
        {
            //This section uses console read line to collect coach info.
            Console.WriteLine("Please enter your first name:");
            string coachFirstName = Console.ReadLine();

            Console.WriteLine("Cool, thanks!  Now enter your last name:");
            string coachLastName = Console.ReadLine();

            string coachPhoneNumber;
            bool isValid = true;
            do
            {
                Console.WriteLine("One last thing... please enter your phone number in the format 555-555-5555");
                coachPhoneNumber = Console.ReadLine();
                isValid = Coach.IsPhoneNumber(coachPhoneNumber);
                if(isValid == false)
                {
                    Console.WriteLine("Incorrect phonenumber format, please try again!");
                }
     

            } while (!isValid);

            //This uses the coach class to create new instance of coach
            Coach coach = new Coach(coachFirstName, coachLastName, coachPhoneNumber);
            return coach;
        }
    }
}
