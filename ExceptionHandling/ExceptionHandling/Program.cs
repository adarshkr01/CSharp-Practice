using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            YoutubeAPI youtubeAPI = new YoutubeAPI();

            try
            {
                youtubeAPI.FetchVideos();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
