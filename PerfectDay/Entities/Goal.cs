using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PerfectDay.Entities
{
    [Table("Goal")]
    public class Goal : BaseEntity
    {

        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        public int Frequency { get; set; }

        [Required]
        public int Deadline { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
