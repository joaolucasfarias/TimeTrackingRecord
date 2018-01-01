using System;
using System.Text;
using Models;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static string ToBase64(this string value) =>
            Convert.ToBase64String(Encoding.UTF8.GetBytes(value));

        public static string FromBase64(this string value) =>
            Encoding.UTF8.GetString(Convert.FromBase64String(value));

        public static int DifferenceHours(this WorkedTimeModel workedTime) =>
            workedTime.Stop.Subtract(workedTime.Start).Hours;

        public static int DifferenceMinutes(this WorkedTimeModel workedTime) =>
            workedTime.Stop.Subtract(workedTime.Start).Minutes;

        public static int DifferenceSeconds(this WorkedTimeModel workedTime) =>
            workedTime.Stop.Subtract(workedTime.Start).Seconds;

        public static double DifferenceTotalHours(this WorkedTimeModel workedTime) =>
            workedTime.Stop.Subtract(workedTime.Start).TotalHours;

        public static double DifferenceTotalMinutes(this WorkedTimeModel workedTime) =>
            workedTime.Stop.Subtract(workedTime.Start).TotalMinutes;

        public static double DifferenceTotalSeconds(this WorkedTimeModel workedTime) =>
            workedTime.Stop.Subtract(workedTime.Start).TotalSeconds;
    }
}
