using System;
//UC1 Validating First Name
//UC2 Validating Last Name
//UC3 Validating Email Id
//UC4 validating Mobile Number of User
//UC5 validating Password Rule1-MiniMum 8 Characters

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
