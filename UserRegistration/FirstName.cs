using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class FirstName
    {
        public static bool IsValidFirstName(string firstName)
        {
            // Regular expression pattern for first name validation
            string pattern = @"^[A-Z][a-zA-Z]{2,}$";

            // Check if the first name matches the pattern
            return Regex.IsMatch(firstName, pattern);
        }
    }
}
