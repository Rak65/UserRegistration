using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Password
    {
        public static bool IsValidPassword(string password)
        {
            // Check if the password length is at least 8 characters
            if (password.Length < 8)
            {
                return false;
            }

            // Check if the password contains at least 1 uppercase letter
            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                return false;
            }
            // Check if the password contains at least 1 numeric character
            if (!Regex.IsMatch(password, @"\d"))
            {
                return false;
            }
            // Check if the password contains exactly 1 special character
            if (!Regex.IsMatch(password, @"^[a-zA-Z0-9]*[^a-zA-Z0-9]{1}[a-zA-Z0-9]*$"))
            {
                return false;
            }


            // All rules passed
            return true;
        }

    }
}
