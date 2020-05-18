using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PerfectDay.Entities
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10), MinLength(3), Required]
        public string Category { get; set; }
        [Required]
        public DateTime StartDateTime { get; set; }
        [Required]
        public DateTime EndDateTime { get; set; }
        [Required]
        public int Frequency { get; set; }
        [MaxLength(100)]
        public string Task_Description { get; set; }
        public int? ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
}