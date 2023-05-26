using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class ValidMobileNumber
    {
        public static bool IsValidMobileNumber(string mobileNumber)
        {
            // Regular expression pattern for mobile number validation
            string pattern = @"^91 \d{10}$";

            // Check if the mobile number matches the pattern
            return Regex.IsMatch(mobileNumber, pattern);
        }
    }
}
