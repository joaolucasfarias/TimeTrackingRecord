using System;

namespace Models
{
    public class WorkedTimeModel
    {
        public DateTime Start { get; private set; }
        public DateTime Stop { get; private set; }

        public void StartCounting() =>
            Start = DateTime.Now;

        public void StopCounting() =>
            Stop = DateTime.Now;
    }
}
