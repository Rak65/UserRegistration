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
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            if (FirstName.IsValidFirstName(firstName))
            {
                Console.WriteLine("Valid first name.");
            }
            else
            {
                Console.WriteLine("Invalid first name.");
            }
            Console.ReadKey();
        }
    }
}
