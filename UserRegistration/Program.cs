using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            if (FirstName.IsValidFirstName(firstName))
            {
                Console.WriteLine("Valid first name.");
            }
            else
            {
                Console.WriteLine("Invalid first name.");
            }*/

            /*Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();

            if (LastName.IsValidLastName(lastName))
            {
                Console.WriteLine("Valid last name.");
            }
            else
            {
                Console.WriteLine("Invalid last name.");
            }*/
            /*Console.WriteLine("Enter your email address: ");
            string email = Console.ReadLine();

            if (ValidEmail.IsValidEmail(email))
            {
                Console.WriteLine("Valid email address.");
            }
            else
            {
                Console.WriteLine("Invalid email address.");
            }*/
            /*Console.WriteLine("Enter your mobile number: ");
            string mobileNumber = Console.ReadLine();

            if (ValidMobileNumber.IsValidMobileNumber(mobileNumber))
            {
                Console.WriteLine("Valid mobile number.");
            }
            else
            {
                Console.WriteLine("Invalid mobile number.");
            }*/
            /*Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            if (Password.IsValidPassword(password))
            {
                Console.WriteLine("Valid password.");
            }
            else
            {
                Console.WriteLine("Invalid password.");
            }*/
            string[] emailSamples = {
            "john@example.com",
            "jane@example.com",
            "invalid_email",
            "test@test@test.com",
            "user123@gmail.com"
            };

            foreach (string email in emailSamples)
            {
                bool isValid = ValidateEmail.VEmail(email);
                Console.WriteLine(email + ": " + (isValid ? "Valid" : "Invalid"));
            }
            Console.ReadKey();
        }
    }
}
