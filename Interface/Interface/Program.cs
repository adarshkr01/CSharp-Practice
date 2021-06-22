using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IActivity> activities = new List<IActivity>();

            UploadToCloud uploadToCloud = new UploadToCloud();
            CallWebServiceProvider callWebServiceProvider = new CallWebServiceProvider();

            //IActivity uploadToCloud = new UploadToCloud();
            //IActivity callWebServiceProvider = new CallWebServiceProvider();

            activities.Add(uploadToCloud);
            activities.Add(callWebServiceProvider);

            WorkflowEngine workflowEngine = new WorkflowEngine(activities);
            workflowEngine.Run();
        }
    }
}
