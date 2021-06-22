using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _strtTime;
        private DateTime _stopTime;

        private bool _stopWatchRunning = false;

        public void Start()
        {
            if (_stopWatchRunning)
            {
                throw new InvalidOperationException();
            }

            _stopWatchRunning = true;
            _strtTime = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            if (!_stopWatchRunning)
            {
                throw new InvalidOperationException();
            }

            _stopWatchRunning = false;

            _stopTime = DateTime.Now;
            TimeSpan timeSpan = _stopTime - _strtTime;

            return timeSpan;
        }
    }
}
