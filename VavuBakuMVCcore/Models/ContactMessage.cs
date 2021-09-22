using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VavuBakuMVCcore.Models
{
    public class ContactMessage
    {
        [Key]
        public int Id { get; set; }

        [EmailAddress]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        [MaxLength(150)]
        public string Subject { get; set; }

        [Required]
        [Phone]
        [MaxLength(50)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(200)]
        public string Message { get; set; }

        public DateTime Date { get; set; }
    }
}
