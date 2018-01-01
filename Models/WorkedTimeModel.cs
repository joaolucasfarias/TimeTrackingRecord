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

        public WorkedTimeModel CreateRecord(string record)
        {
            if (!record.Contains(";")) throw new ArgumentException("Not a valid record", nameof(record));

            var startStop = record.Split(';');
            Start = DateTime.Parse(startStop[0]);
            Stop = DateTime.Parse(startStop[1]);

            return this;
        }
    }
}
