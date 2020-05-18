using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PerfectDay.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Login { get; set; }

        [Required, MaxLength(50)]
        public string Password { get; set; }

        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Surname { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }
        public int? ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
}
