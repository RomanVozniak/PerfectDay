using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PerfectDay.Entities
{
    [Table("Goal")]
    public class Goal
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }
        public int Frequency { get; set; }
        public int Deadline { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public int HistoryId { get; set; }
        public History History { get; set; }

    }
}
