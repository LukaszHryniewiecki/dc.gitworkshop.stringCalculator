using System;

namespace dc.gitworkshop.stringCalculator
{
    public class StringCalculator
    {
        public static string Compute(string input)
        {
            var isok = Validate(input, out string error);
            if (isok)
            {
                return Sum(input);
            }
            else
            {
                return error;
            }
        }

        private static bool Validate(string input, out string error)
        {
            error = null;
            return true;


            int result = 0;
            String[] separators = new[] { ",", "\n", ">"};
            String[] numbers = input.Split(separators, StringSplitOptions.None);
            foreach (String numberString in numbers)
            {
                int number = Int32.Parse(numberString);
                if (number < 0 )
                {
                    error = "negatives not allowed";
                    return false;
                }
            }
            return true;
        }

        private static string Sum(string input)
        {
            if (input.Length <= 0)
                return "0";

            int result = 0;
            String[] separators = new[] { ",", "\n" };
            String[] numbers = input.Split(separators, StringSplitOptions.None);
            foreach (String numberString in numbers)
            {
                bool resParse;
                int number;
                resParse = Int32.TryParse(numberString, out number);
                if (!resParse)
                    return "0";
                else if (number < 0)
                {
                    return "negatives not allowed";
                }
                else if (number >= 1500)
                {
                    return "numbers greater than 1500 not allowed";
                }
                else if (number >= 1000)
                {
                    continue;
                }

                result += number;
            }
            return result.ToString();
        }

    }
}