using System.Text.RegularExpressions;

namespace HtmlTags
{
    internal class Program
    {
        public static bool
    isValidHTMLTag(string str)
        {
            // Regex to check valid HTML tag.
            string regex
              = "<(\\S*?)[^>]>.?</\\1>|<.*?/>";

            Regex r = new Regex(regex);

            // If the string is empty return false
            if (str == null)
            {
                return false;
            }

            // using Pattern.matcher()
            Match m = r.Match(str);

            // Return if the string matched the ReGex
            return m.Success;
        }
        static void Main(string[] args)
        {
            string str1 = "<input value = '>'>";
            Console.WriteLine(isValidHTMLTag(str1));

            string str2 = "<br/>";
            Console.WriteLine(isValidHTMLTag(str2));

            string str3 = "br/>";
            Console.WriteLine(isValidHTMLTag(str3));

            string str4 = "<'br/>";
            Console.WriteLine(isValidHTMLTag(str4));
        }
    }
}