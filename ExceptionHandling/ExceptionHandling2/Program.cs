using System;
using System.IO;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader streamReader = new StreamReader(@"C:\sample_file.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }

            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.FileName);
            }
        }
    }
}
