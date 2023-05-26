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

            // All rules passed
            return true;
        }

    }
}
