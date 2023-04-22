using System.Text.RegularExpressions;

namespace LowerCase
{
    internal class Program
    {
        public static string myString = @"^[a-z]+_[a-z]+$";
        static void Main(string[] args)
        {
            Regex r = new Regex(Program.myString);
            Console.WriteLine("Enter a String : ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}