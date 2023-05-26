using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Password
    {
        public static bool IsValidPassword(string password)
        {
            // Check if the password length is at least 8 characters
            return password.Length >= 8;
        }
    }
}
