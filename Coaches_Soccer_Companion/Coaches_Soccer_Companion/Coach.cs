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
    }
}
