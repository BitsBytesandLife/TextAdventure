using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventure
{
   public class taAppUI
    {

        public static bool GetUserConsent(string question)

        {
            string[] yesOptions = { "Y", "YES", "YEP", "SURE", "OK", "YEAH" };
            string[] noOptions = { "N", "NO", "NOPE", "NAH" };

            while (true)
            {
                Console.WriteLine(question);
                string userResponse = Console.ReadLine().Trim();

                if (yesOptions.Contains(userResponse.ToUpper()))
                {
                    return true;
                }
                else if (noOptions.Contains(userResponse.ToUpper()))
                {
                    return false;
                }
            }

        }


        public static string ValidationMenuChoice(string question)

        {

            string[] menuOptions = { "1", "2", "3", "4"};

            while (true)
            {
                Console.WriteLine(question);
                string userResponse = Console.ReadLine().Trim();

                if (menuOptions.Contains(userResponse))
                {
                    return userResponse;
                }

            }
        }

        public static int ValidateInteger(string question)
        {
            int number = 0;
            string str = "";
            while (!int.TryParse(str, out number))
            {
                Console.WriteLine(question);
                str = Console.ReadLine();
            }
            return number;
        }

        public static decimal ValidateDecimal(string question)
        {
            string str = "";
            decimal dec = 0;
            while (!Decimal.TryParse(str, out dec))
            {
                Console.WriteLine(question);
                str = Console.ReadLine();
            }
            return dec;
        }

        public static string ValidateString(string question)
        {
            string str = "";
            while (string.IsNullOrEmpty(str))
            {
                Console.WriteLine(question);
                str = Console.ReadLine();
            }

            return str;
        }

        public static string ValidateChoices(string question, string[] validCondition)
        {

            while (true)
            {
                Console.WriteLine(question);
                string userResponse = Console.ReadLine().Trim().ToUpper();

                if (validCondition.Contains(userResponse))
                {
                    return userResponse;
                }
            }
        }



    }
}
