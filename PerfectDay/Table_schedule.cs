using System;

namespace PerfectDay
{
    public class Schedule
    {
        public int Schedule_Id { get; set; }
        public int User_Id { get; set; }
        public TimeSpan availableTime { get; set; }
        public char taskSet { get; set; }
        public DateTime day { get; set; }
    }
}