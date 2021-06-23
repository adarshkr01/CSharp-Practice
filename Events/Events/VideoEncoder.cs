using System;
using System.Threading;

namespace Events
{
    class VideoEncoder
    {
        // 1. Define a delegate
        // 2. Define an event based on the delegate
        // 3. Raise/Publish the event

        // 1.
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        // 2.
        public event VideoEncodedEventHandler VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video); // publish the event
        }

        // 3.
        protected virtual void OnVideoEncoded(Video video) // event publisher should be protected and virtual
        {
            if (VideoEncoded != null) // checking if there are any subscribers
            {
                // VideoEncoded(this, EventArgs.Empty);
                // Event with empty argument

            }    
        }
    }
}
