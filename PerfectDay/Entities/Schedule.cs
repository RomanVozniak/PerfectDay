using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PerfectDay.Entities
{
    public class Schedule : BaseEntity
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public TimeSpan availableTime { get; set; }
        public char taskSet { get; set; }
        public DateTime day { get; set; }
    }
}
