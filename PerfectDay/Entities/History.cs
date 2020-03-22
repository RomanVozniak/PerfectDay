using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfectDay.Entities
{
    public class History
    {   [Key]
        public int GoalHistoryId { get; set; }
        [ForeignKey("Goal")]
        public int GoalId { get; set; }
        public DateTime updateTime { get; set; }
    }
}
