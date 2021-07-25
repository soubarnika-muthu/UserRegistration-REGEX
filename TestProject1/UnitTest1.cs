using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        UserRegistration userRegistration;
        UserRegistrationAnnotation user;
        [TestInitialize]
        public void TestSetup()
        {
            userRegistration = new UserRegistrationProblem.UserRegistration();
            user = new UserRegistrationAnnotation();
        }
        [TestCategory("NameTest")]
        [TestMethod]
        public void TestFirstName1()
        {
            //Assign
            string expected = "1";
            string name = "Soubarnika";
            //act
            string actual = userRegistration.ValidatingFirstName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestFirstName2()
        {
            //Assign
            string expected = "0";
            string name = "soub3nik";
            //act
            string actual = userRegistration.ValidatingFirstName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestFirstNameException()
        {
            //Assign
            string expected = "Name should not be empty";
            string name = "";
            try
            {
                //act
                string actual = userRegistration.ValidatingFirstName(name);
                Assert.AreEqual(actual, expected);
            }
            catch (CustomException e)
            {
                //assert
                Assert.AreEqual(e.Message, expected);
            }
        }
        [TestMethod]
        public void TestLastName1()
        {
            //Assign
            string expected = "1";
            string name = "Muthu";
            //act
            string actual = userRegistration.ValidatingFirstName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestLastName2()
        {
            //Assign
            string expected = "0";
            string name = "muthu2";
            //act
            string actual = userRegistration.ValidatingFirstName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestLastNameException()
        {
            //Assign
            string expected = "Name should not be null";
            string name = null;
            try
            {
                //act
                string actual = userRegistration.ValidatingFirstName(name);
                Assert.AreEqual(actual, expected);
            }
            catch (CustomException e)
            {
                //assert
                Assert.AreEqual(e.Message, expected);
            }
        }
        [TestCategory("Email")]
        [TestMethod]
        public void EmailTest1()
        {
            //Assign
            string expected = "1";
            string emailId = "abc-100@yahoo.com";
            //act
            string actual = userRegistration.ValidatingEmail(emailId);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void EmailTest2()
        {
            //Assign
            string expected = "0";
            string emailId = "sou-@gmail@gmail.com";
            //act
            string actual = userRegistration.ValidatingEmail(emailId);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void EmailExceptionTest()
        {
            //Assign
            string expected = "Email should not be null";
            string emailId = null;
            //act
            string actual = userRegistration.ValidatingEmail(emailId);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCategory("Moblie number validation")]
        [TestMethod]
        public void MobileTest1()
        {
            //Assign
            string expected = "1";
            string mobileNo = "91 7373377956";
            //act
            string actual = userRegistration.ValidatingMobileNo(mobileNo);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void MobileTest2()
        {
            //Assign
            string expected = "0";
            string mobileNo = "919826737645";
            //act
            string actual = userRegistration.ValidatingMobileNo(mobileNo);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void PasswordTest1()
        {
            //Assign
            string expected = "1";
            string password = "Chan@748292";
            //act
            string actual = userRegistration.ValidatingPassword(password);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void PasswordTest2()
        {
            //Assign
            string expected = "0";
            string password = "muthu9629";
            //act
            string actual = userRegistration.ValidatingPassword(password);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void PasswordExceptionTest()
        {
            //Assign
            string expected = "Password should not be empty";
            string password = "";
            //act
            try
            {
                string actual = userRegistration.ValidatingPassword(password);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ce)
            {
                //assert
                Assert.AreEqual(ce.Message, expected);
            }
        }
       

        /// <summary>
        /// Checks for validation using annotation = if name is not valid 
        /// </summary>
        [TestMethod]
        public void CheckForValidation1()
        {
            user.firstName = "so";
            user.lastName = "Muthu";
            user.phoneNumber = "9908735627";
            user.EmailAddress = "abc@gmail.com";
            user.Password = "Exo@chanbaek21";
            string expected = "First Name should be min of 3";
            string actual = UserRegistration.TestUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checks for validation using annotation = if phone number not valid
        /// </summary>
        [TestMethod]
        public void CheckForValidation2()
        {
            user.firstName = "Soubak";
            user.lastName = "Muthu";
            user.phoneNumber = "99087356";
            user.EmailAddress = "abc@gmail.com";
            user.Password = "Exo@chanbaek21";
            string expected = "Phone number should exactly 10";
            string actual = UserRegistration.TestUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checks for validation and return happy if validation is true
        /// </summary>
        [TestMethod]
        public void CheckValidityAndReturnHappy()
        {
            user.firstName = "Soubarnika";
            user.lastName = "Muthu";
            user.phoneNumber = "9908735632";
            user.EmailAddress = "abc@gmail.com";
            user.Password = "Exo@chanbaek21";
            string expected = "Happy";
            string actual = UserRegistration.TestUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checks for validation and return sad if validation is false
        /// </summary>
        [TestMethod]
        public void CheckValidityAndReturnSad()
        {
            user.firstName = "Soubarnika";
            user.lastName = "Muthu";
            user.phoneNumber = "99087356";
            user.EmailAddress = "abc@gmail.com";
            user.Password = "Exo@chanbaek21";
            string expected = "Sad";
            string actual = UserRegistration.TestUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }


    }
}
