using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaches_Soccer_Companion
{
    class Coach : Participants
    {

        public string phonenumber;

        public Coach(string aPhoneNumber, string aFirstName, string aLastName) : base(aFirstName, aLastName)
        {
            phonenumber = aPhoneNumber;
        }
        public void SayMyName(int age)
        {
            Console.WriteLine($"Name: {firstname} {lastname} GUID: {ParticipantID} Age: {age} Phone Number: {phonenumber}");
        }
    }
}
