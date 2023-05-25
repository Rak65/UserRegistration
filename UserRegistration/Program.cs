﻿using System;
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
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            if (IsValidFirstName(firstName))
            {
                Console.WriteLine("Valid first name.");
            }
            else
            {
                Console.WriteLine("Invalid first name.");
            }
            Console.ReadKey();
        }
        static bool IsValidFirstName(string firstName)
        {
            // Regular expression pattern for first name validation
            string pattern = @"^[A-Z][a-zA-Z]{2,}$";

            // Check if the first name matches the pattern
            return Regex.IsMatch(firstName, pattern);
        }
    }
}
