using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfectDay.Entities
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public TimeSpan availableTime { get; set; }
        public char taskSet { get; set; }
        public DateTime day { get; set; }
    }
}
