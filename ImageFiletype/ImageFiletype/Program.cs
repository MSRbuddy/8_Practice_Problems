using System.Text.RegularExpressions;

namespace ImageFiletype
{
    internal class Program
    {
        public static string ImageSrc = @"^<[a-zA-Z]+(\s+[a-zA-Z]+\s*=\s*(""([^""])""|'([^'])'))\s/>$";
        static void Main(string[] args)
        {
            string str = "<img src=\"test.gif\"/>";
            Regex r = new Regex(Program.ImageSrc);
            Console.WriteLine("Enter a FileName of Image Type : ");
            Console.WriteLine(r.IsMatch(str));
        }
    }
}