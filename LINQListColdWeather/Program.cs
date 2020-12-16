using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQListColdWeather
{
    enum DayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    class Weather
    {
        public DayOfWeek Day { get; set; }
        public int HighTemp { get; set; }
        public int LowTemp { get; set; }
        public Weather(DayOfWeek day, int high, int low)
        {
            Day = day;
            HighTemp = high;
            LowTemp = low;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Weather> daysForecasted = new List<Weather>();
            daysForecasted.Add(new Weather(DayOfWeek.Tuesday, 34, 27));
            daysForecasted.Add(new Weather(DayOfWeek.Wednesday, 35, 28));
            daysForecasted.Add(new Weather(DayOfWeek.Thursday, 36, 26));
            daysForecasted.Add(new Weather(DayOfWeek.Friday, 38, 28));
            daysForecasted.Add(new Weather(DayOfWeek.Saturday, 42, 33));
            var coldDays =
                from forecast in daysForecasted
                where forecast.HighTemp < 40
                select forecast;
            foreach (var forecast in coldDays)
            {
                Console.WriteLine("Cold weather on {0}", forecast.Day);
            }
        }
    }
}
