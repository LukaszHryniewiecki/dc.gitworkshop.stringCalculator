namespace dc.gitworkshop.stringCalculator
{
    public class Generator
    {
        public static string Random(int count, string delimiter, bool allowNegatives = false)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += "0,";
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