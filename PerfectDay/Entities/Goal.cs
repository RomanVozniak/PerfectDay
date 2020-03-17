using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfectDay.Entities
{
    public class Goal
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Frequency { get; set; }
        public int Deadline { get; set; }
        public string GoalDescription{ get; set; }
    }
}
