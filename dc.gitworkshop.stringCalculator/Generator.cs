using System;

namespace dc.gitworkshop.stringCalculator
{
    public class Generator
    {
        public static string Random(int count, string delimiter, bool allowNegatives = false)
        {
            Random r = new Random();
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += r.Next() + delimiter;
            }
            if(result.Length!=0)
                return result.Substring(0, result.Length - 1);
            else
            {
                return "";
            }
        }
    }
}