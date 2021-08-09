using System;

namespace IndexersPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            Console.WriteLine(company[5]);
            Console.WriteLine(company[5, Department.Cloud]);
            Console.WriteLine(company[Department.Cloud]);
        }
    }
}
