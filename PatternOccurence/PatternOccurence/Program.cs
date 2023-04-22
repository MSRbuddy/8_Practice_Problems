using System.Text.RegularExpressions;

namespace PatternOccurence
{
    public class Program
    {
        public int CountCharsUsingRegex(string source, char toFind)
        {
            return new Regex(Regex.Escape(toFind.ToString())).Matches(source).Count;
        }
       
        static void Main(string[] args)
        {
            string main = "Mary Had A Little Lamb";
            char toFind = 'L';
            int actual = _countChars.CountCharsUsingRegex(main, toFind);
            Assert.Equal(2, actual);
        }
    }
}