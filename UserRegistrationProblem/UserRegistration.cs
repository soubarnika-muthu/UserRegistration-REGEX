﻿using System;
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
