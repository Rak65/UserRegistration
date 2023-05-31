using UserRegistration;


namespace EmailTest
{
    [TestFixture]
    public class EmailValidationTests
    {
        [TestCase("abc-100@yahoo.com",true)]
        [TestCase("abc.100@yahoo.com",true)]
        [TestCase("abc111@abc.com",true)]
        [TestCase("abc-100@abc.net",true)]
        [TestCase("abc.100@abc.com.au",true)] 
        [TestCase("abc@1.com",true)]
        [TestCase("abc@gmail.com",true)] 
        [TestCase("johndoe@example.com", true)]
        [TestCase("jane.doe@example.co.uk", true)]
        [TestCase("invalid_email", false)]
        [TestCase("test@test@test.com", false)]
        [TestCase("user123@gmail.com", true)]
        public static void ValidateEmail_ValidEntries_ReturnsExpectedResult(string email, bool expectedResult)
        {
            // Act
            bool isValid = ValidateEmail.VEmail(email);

            // Assert
            Assert.That(isValid, Is.EqualTo(expectedResult));
        }

        
    }
}