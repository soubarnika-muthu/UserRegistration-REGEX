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
        //method to validate email
         public void ValidatingEmail()
        {
            string pattern = @"^[a-zA-z]{3}([\+ \- _ \.]*[a-zA-Z0-9]+)*[@][a-zA-z0-9]+(\.[a-z]{2,3})*$";
            string[] inputs = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc", "abc.com", "abc123@gmail.a" };

            Regex regex = new Regex(pattern);
            Console.WriteLine("validating Email");
            IterateLoop(inputs, regex);
        }
        //Method to validate Mobile Number of User
        public void ValidatingMobileNo()
        {
            string pattern = "^([9][1])+[ ]+[789]{1}[0-9]{9}$";
            string[] inputs = { "919629522931", "91 8220538351", "9629459258", "7435627891", "91 9629", "19 9234567811","91 7302456786","91 8220523456" };
            Regex regex = new Regex(pattern);
            Console.WriteLine("validating Mobile Number of User");
            IterateLoop(inputs, regex);
        }
        //Method to validate first name
        public void ValidatingPassword()
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";//Minimum 8 characters with one uppercase
            string[] inputs = { "Soubarnika", "geminika", "SHANTHIV", "Venkat", "9629muthu","SouMuthu"};
            Regex regex = new Regex(pattern);
            Console.WriteLine("validating Password Contains Minimum 8 Charaters");
            IterateLoop(inputs, regex);
        }
        //method to find whether given input is matching with pattern
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
