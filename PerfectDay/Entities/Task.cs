<<<<<<< HEAD
﻿using System;
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
        public string Duration { get; set; }
        [Required]
        public int Frequency { get; set; }
        [MaxLength(100)]
        public string Task_Description { get; set; }
        public int? ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
=======
﻿using System;
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
        public string Duration { get; set; }
        [Required]
        public int Frequency { get; set; }
        [MaxLength(100)]
        public string Task_Description { get; set; }
        public int? ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
>>>>>>> 2af223880cfa8e9e7eecdc180d704204292cf137
}