using System;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Very very long words are in this passage.";
            string shortenedStr = str.Shorten(5);
            Console.WriteLine(shortenedStr);
        }
    }


    public static class StringExtensions
    {
        public static string Shorten(this String str, int noOfWords)
        {
            if (noOfWords < 0)
                throw new ArgumentOutOfRangeException();

            if (noOfWords == 0)
                return "";

            string[] words = str.Split(" ");

            if (words.Length <= noOfWords)
                return str;

            return string.Join(" ", words.Take(noOfWords)) + "...";
        }
    }
}
