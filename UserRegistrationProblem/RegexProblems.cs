using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    class RegexProblems
    {
        public static void ValidateingFirstName()
        {
            //array for list of testcases
            string[] firstName = { "Sai", "Vijaya", "Kumar", "Ram", "123", "sai", "Sa", "1sa", " Sai", "kFc" };
            //regex for FirstName
            string s = @"^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(s);

            foreach (string i in firstName)
            {
                Match res = regex.Match(i);
                if (res.Success)
                {
                    Console.WriteLine($"Valid --> {i}");
                }
                else
                {
                    Console.WriteLine($"InValid --> {i}");
                }
            }
        }
        public static void ValidateingLastName()
        {
            //array for list of testcases
            string[] lastName = { "Sai", "Vijaya", "Kumar", "Ram", "123", "sai", "Sa", "1sa", " Sai", "kFc" };
            //regex for LastName
            string s = @"^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(s);

            foreach (string i in lastName)
            {
                Match res = regex.Match(i);
                if (res.Success)
                {
                    Console.WriteLine($"Valid --> {i}");
                }
                else
                {
                    Console.WriteLine($"InValid --> {i}");
                }
            }
        }
        public static void ValidateingEmail()
        {
            //array for list of emails
            string[] email = { "abc@gmail.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com","abc", "abc@.com.my", "abc123@.com.com", "abc123@.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", ".abc@abc.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            //regex pattern for email
            string s = @"^abc([+. \-_]{1}\w+)?@[a-z0-9]+\.[a-z]{2,3}(\.[a-z]{2,3})?$";
            Regex regex = new Regex(s);
            foreach (string i in email)
            {
                Match res = regex.Match(i);
                if (res.Success)
                {
                    Console.WriteLine($"Valid --> {i}");
                }
                else
                {
                    Console.WriteLine($"InValid --> {i}");
                }
            }

        }
        public static void ValidateingPhoneNumber()
        {
            //array for list of Numbers
            string[] mobileNumber = { "91 9866201443", "21 9876543210", "3 7095821", "07 7095821264", "5 8897023502", "67 1234567890" };
            //regex pattern for Number
            string s = @"^[1-9]{2}[ ][0-9]{10}$";
            Regex regex = new Regex(s);
            foreach (string i in mobileNumber)
            {
                Match res = regex.Match(i);
                if (res.Success)
                {
                    Console.WriteLine($"Valid --> {i}");
                }
                else
                {
                    Console.WriteLine($"InValid --> {i}");
                }
            }
        }
    }
}
