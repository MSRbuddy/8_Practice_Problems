using System.Text.RegularExpressions;

namespace StringMatch
{
    internal class Program
    {
        public static string myString = @"^ab{2,3}$";
        static void Main(string[] args)
        {
            Regex r = new Regex(Program.myString);
            Console.WriteLine("Enter a String : ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}