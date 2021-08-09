using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    public class YoutubeAPI
    {
        public void FetchVideos()
        {
            try
            {
                throw new Exception("Some low level Youtube Exception occured");
            }
            catch (Exception ex)
            {
                // Some logging

                throw new YoutubeException("Could not load videos", ex);
            }
        }
    }
}
