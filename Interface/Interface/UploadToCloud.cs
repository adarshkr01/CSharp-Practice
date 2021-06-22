using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class UploadToCloud : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploaded a video to cloud.");
        }
    }
}
