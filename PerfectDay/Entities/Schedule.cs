using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PerfectDay.Entities
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public TimeSpan availableTime { get; set; }
        public string taskSet { get; set; }
        public DateTime day { get; set; }
        public ICollection<Goal> Goals { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public User User { get; set; }

    }
}
