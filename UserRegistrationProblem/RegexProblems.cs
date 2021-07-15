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
            string[] firstName = { "Sai", "Vijaya", "Kumar", "Ram", "ram", "sai", "Sa", "1sa", " Sai", "kFc" };
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
    }
}
