using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            string title;
            string description;
            int choice;

            Console.WriteLine("Enter Title: ");
            title = Console.ReadLine();

            Console.WriteLine("Enter Description: ");
            description = Console.ReadLine();

            Post post = new Post(title, description);

            while(true)
            {
                Console.WriteLine("\n1. View Post | 2. Upvote | 3. Downvote | 4. Exit");
                int.TryParse(Console.ReadLine(), out choice);

                if (choice == 4)
                    break;

                switch(choice)
                {
                    case 1:
                        post.ShowPost();
                        break;

                    case 2:
                        post.Upvote();
                        break;

                    case 3:
                        post.DownVote();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice. Try again!");
                        break;
                }
            }
        }
    }
}
