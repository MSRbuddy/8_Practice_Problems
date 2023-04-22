using System.Text.RegularExpressions;

namespace WebsiteAddress
{
    internal class Program
    {
        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            string str = "https://example.com";
            Console.WriteLine("Matching URL...");
            showMatch(str, @"^(http|http(s)?://)?([\w-]+\.)+[\w-]+[.com|.in|.org]+(\[\?%&=]*)?");
        }
    }
}