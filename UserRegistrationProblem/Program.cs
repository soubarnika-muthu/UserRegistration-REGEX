using System;
//UC1 Validating First Name
//UC2 Validating Last Name
//UC2 Validating Email Id

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
            user.ValidatingEmail();
        }
    }
}
