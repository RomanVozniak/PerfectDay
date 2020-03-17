using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfectDay.Entities
{
    public class Goal
    {
        public int Id { get; set; }
        public String Description { get; set; }
        public int Frequency { get; set; }
    }
}
