using System;
//UC1 Validating First Name
//UC2 Validating Last Name
//UC3 Validating Email Id
//UC4 validating Mobile Number of User
//UC5 validating Password Rule1-MiniMum 8 Characters
//UC6 validating Password Rule2-Atleast one upper case
//UC7 validating Password Rule3-Atleast one  number
//UC8 validating Password Rule4-Exactly one  special character


namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementaion of User Registration Problem");
         //   creating object for User Registration class
            UserRegistration user = new UserRegistration();
            // user.ValidatingFirstName();
            //user.ValidatingLastName();
            //user.ValidatingEmail();
            // user.ValidatingMobileNo();
           
            user.ValidatingPassword();
        }
    }
}
