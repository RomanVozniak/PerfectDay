using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PerfectDay.Entities
{
    [Table("Goal")]
    public class Goal
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        public int Frequency { get; set; }

        [Required]
        public int Deadline { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
