using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PerfectDay.Entities
{
    public class History : BaseEntity
    {   
        [ForeignKey("Goal")]
        public int GoalId { get; set; }
        public DateTime updateTime { get; set; }
    }
}
