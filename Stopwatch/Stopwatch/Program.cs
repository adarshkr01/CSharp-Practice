using System;

namespace Stopwatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stp = new Stopwatch();
            TimeSpan tsp;
            int choice;

            while(true)
            {
                Console.Write("1. Start\n2. Stop\n3. Exit\nChoice: ");
                int.TryParse(Console.ReadLine(), out choice);

                if (choice == 3)
                    break;

                switch(choice)
                {
                    case 1:
                        try
                        {
                            stp.Start();
                            Console.WriteLine("Stopwatch started!");
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("The Stopwatch is already running!");
                        }
                        
                        break;

                    case 2:
                        try
                        {
                            tsp = stp.Stop();
                            Console.WriteLine("The stopwatch ran for {0}", tsp);

                        }
                        catch (Exception)
                        {

                            Console.WriteLine("The Stopwatch is not running!");
                        }
                        break;
                }
            }
        }
    }
}
