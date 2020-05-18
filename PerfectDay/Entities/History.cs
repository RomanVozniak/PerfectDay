using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PerfectDay.Entities
{
    public class History
    {   
        [Key]
        public int Id { get; set; }
        public DateTime updateTime { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        public Goal Goal { get; set; }
    }
}
