using System;

namespace Models
{
    public class WorkedTimeModel
    {
        public DateTime Start { get; private set; }
        public DateTime Stop { get; private set; }
        public double SumTotalMinutesGroup { get; set; }

        public string SumTotalMinutesInHours =>
            TimeSpan.FromMinutes(SumTotalMinutesGroup).ToString(@"hh\:mm\:ss");

        public int DifferenceHours => SubtractDifferenceHours();
        private int SubtractDifferenceHours() =>
            Stop.Subtract(Start).Hours;

        public int DifferenceMinutes => SubtractDifferenceMinutes();
        private int SubtractDifferenceMinutes() =>
            Stop.Subtract(Start).Minutes;

        public int DifferenceSeconds => SubtractDifferenceSeconds();
        private int SubtractDifferenceSeconds() =>
            Stop.Subtract(Start).Seconds;

        public double TotalDifferenceInHours => SubtractTotalDifferenceInHours();
        private double SubtractTotalDifferenceInHours() =>
            Stop.Subtract(Start).TotalHours;

        public double TotalDifferenceInMinutes => SubtractTotalDifferenceInMinutes();
        private double SubtractTotalDifferenceInMinutes() =>
            Stop.Subtract(Start).TotalMinutes;

        public double TotalDifferenceInSeconds => SubtractTotalDifferenceInSeconds();
        private double SubtractTotalDifferenceInSeconds() =>
            Stop.Subtract(Start).TotalSeconds;

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

        public WorkedTimeModel CreateRecord(DateTime start, DateTime stop)
        {
            Start = start;
            Stop = stop;

            return this;
        }

        public WorkedTimeModel CreateGroupedRecord(DateTime start, double sumTotalMinutesGroup)
        {
            Start = start;
            SumTotalMinutesGroup = sumTotalMinutesGroup;

            return this;
        }
    }
}
