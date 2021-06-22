using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class WorkflowEngine
    {
        private readonly List<IActivity> _activities;

        public WorkflowEngine(List<IActivity> activities)
        {
            _activities = activities;
        }

        public void Run()
        {
            foreach(IActivity activity in _activities)
            {
                activity.Execute();
            }
        }
    }
}
