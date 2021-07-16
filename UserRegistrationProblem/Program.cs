using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("\t\t------>Welcome To Regex Programs<----------\n");
            Console.WriteLine("----------------------");
            Console.WriteLine(" 1.First Name\n 2.Last Name\n 3.Email\n 4.Phone Number\n 5.Password\n");
            Console.WriteLine("----------------------");
            Console.Write("Enter Your Option which you want to see: ");
            string choice = Console.ReadLine();
            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Posible validation for First Name");
                    RegexProblems.ValidateingFirstName();
                    break;
                case "2":
                    Console.WriteLine("Posible validation for Last Name");
                    RegexProblems.ValidateingLastName();
                    break;
                case "3":
                    Console.WriteLine("Posible validation for Email");
                    RegexProblems.ValidateingEmail();
                    break;
                case "4":
                    Console.WriteLine("Posible validation for Phone Number");
                    RegexProblems.ValidateingPhoneNumber();
                    break;
                case "5":
                    Console.WriteLine("Posible validation for Password");
                    RegexProblems.ValidateingPassword();
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }
            Console.ReadLine();
        }
    }
}
