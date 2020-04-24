using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PerfectDay.Entities
{
    public class History
    {   
        [Key]
        public int Id { get; set; }
        public DateTime updateTime { get; set; }
    }
}
