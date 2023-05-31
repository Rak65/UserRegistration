using UserRegistration;

namespace UserEntryValidationTests
{
    [TestFixture]
    public class UserEntryValidationTests
    {
        [Test]
        public void HappyTestCase_ValidEntries_Success()
        {
            // Arrange
            string firstName = "Rakesh";
            string lastName = "Kumar";
            string email = "abc@yahoo.com";
            string mobileNumber = "91 9919819801";
            string password = "P@ssw0rd";

            // Act & Assert
            Assert.IsTrue(FirstName.IsValidFirstName(firstName));
            Assert.IsTrue(LastName.IsValidLastName(lastName));
            Assert.IsTrue(ValidEmail.IsValidEmail(email));
            Assert.IsTrue(ValidMobileNumber.IsValidMobileNumber(mobileNumber));
            Assert.IsTrue(Password.IsValidPassword(password));
        }

        [Test]
        public void SadTestCase_InvalidEntries_Failure()
        {
            // Arrange
            string firstName = "";
            string lastName = "roes";
            string email = "abc@yahoo.com.1a";
            string mobileNumber = "12345";
            string password = "password";

            // Act & Assert
            Assert.IsFalse(FirstName.IsValidFirstName(firstName));
            Assert.IsFalse(LastName.IsValidLastName(lastName));
            Assert.IsFalse(ValidEmail.IsValidEmail(email));
            Assert.IsFalse(ValidMobileNumber.IsValidMobileNumber(mobileNumber));
            Assert.IsFalse(Password.IsValidPassword(password));
        }
    }
}