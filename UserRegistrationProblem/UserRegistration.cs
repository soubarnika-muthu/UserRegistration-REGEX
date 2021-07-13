using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class UserRegistration
    {
      //Method to validate first name
        public void ValidatingFirstName()
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}";
            string[] inputs = { "Sou", "gemini", "DEV", "Venkat" ,"So","1Shanthi"};
            Regex regex = new Regex(pattern);
            Console.WriteLine("validating First Name of user");
            IterateLoop(inputs, regex);
        }
        //Method to validate Last name of User
        public void ValidatingLastName()
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}";
            string[] inputs = { "Muthu", "krish", "KUMAR", "2Venkat", "s", "S" };
            Regex regex = new Regex(pattern);
            Console.WriteLine("validating Last Name of User");
            IterateLoop(inputs, regex);
        }
        public static void IterateLoop(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool result = regex.IsMatch(arr[i]);
                if (result == true)
                {
                    Console.WriteLine(arr[i] + "------->" + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + "------->" + "Invalid");
                }
            }
        }

    }
}
