using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using System.ComponentModel.DataAnnotations;

namespace UserRegistrationProblem
{
    public class UserRegistration
    {
        //Method to validate first name
        public string ValidatingFirstName(string name)
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}";
            // string[] name = { "Sou", "gemini", "DEV", "Venkat", "So", "1Shanthi" };
            Regex regex = new Regex(pattern);

            try
            {
                if (name == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION, "Name should not be null");
                }
                if (name == "")
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Name should not be empty");
                }
                if (regex.IsMatch(name))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (NullReferenceException e)
            {
                return (e.Message);
            }
        }
        //Method to validate Last name of User
        public void ValidatingLastName(string lname)
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}";
            // string[] inputs = { "Muthu", "krish", "KUMAR", "2Venkat", "s", "S" };
            Regex regex = new Regex(pattern);
            Console.WriteLine("validating Last Name of User");

        }
        //method to validate email
        public string ValidatingEmail(string mail)
        {
            string pattern = @"^[a-zA-z]{3}([\+ \- _ \.]*[a-zA-Z0-9]+)*[@][a-zA-z0-9]+(\.[a-z]{2,3})*$";
            // string[] inputs = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" ,"abc","abc@.com","abc123@gmail.a", "abc123@.com" ,
            // "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a"};

            Regex regex = new Regex(pattern);
            try
            {
                if (regex.IsMatch(mail))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception e)
            {
                return "Email should not be null";
            }


        }
        //Method to validate Mobile Number of User
        public string ValidatingMobileNo(string number)
        {
            string pattern = "^([9][1])+[ ]+[789]{1}[0-9]{9}$";
            // string[] inputs = { "919629522931", "91 8220538351", "9629459258", "7435627891", "91 9629", "19 9234567811", "91 7302456786", "91 8220523456" };
            Regex regex = new Regex(pattern);
            try
            {
                if (number == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION, "Number should not be null");
                }
                if (number == "")
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Number should not be empty");
                }
                if (regex.IsMatch(number))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }
        //Method to validate Password
        public string ValidatingPassword(string password)
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&-+=()]).{8,}$";//minimum 8 characters with atleast one upper ,lowercase ,number,special character
                                                                                           //  string[] inputs = { "Soubar@20", "geminika@", "SRILEKHA", "Venkat123", "1Muthu", "Sou@Muthu","Srilekha@2021 ","Nandhini&962","shanthi@222"};
            Regex regex = new Regex(pattern);
            try
            {
                if (password == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION, "Password should not be null");
                }
                if (password == "")
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Password should not be empty");
                }
                if (regex.IsMatch(password))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception e)
            {
                return (e.Message);
            }

        }
        public static string TestUserRegistration(UserRegistrationAnnotation userRegistration)
        {
            //creating object for validation context and passing the validation class
            ValidationContext validationContext = new ValidationContext(userRegistration, null, null);
            //store the resukt of validation in list
            List<ValidationResult> validationResults = new List<ValidationResult>();
            //if all the result in lista re true 
            bool valid = Validator.TryValidateObject(userRegistration, validationContext, validationResults, true);
            try
            {
                //if any one is not valid then return the error message
                if (!valid)
                {
                    foreach (ValidationResult i in validationResults)
                    {
                        //throwing invalid extry exception in custom exception class
                        throw new CustomException(CustomException.ExceptionType.INVALID_ENTRY_EXCEPTION, "" + i.ToString());
                    }
                    throw new CustomException(CustomException.ExceptionType.NULL_FIELD_EXCEPTION, "No Field Found");
                }
                //else return validation satisfied
                else
                {
                    return "Happy";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

    }

}


