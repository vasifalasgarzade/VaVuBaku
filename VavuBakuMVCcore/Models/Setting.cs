using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VavuBakuMVCcore.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }

        [Phone]
        [MaxLength(50)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string PhoneIcon { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string AddressIcon { get; set; }


        [EmailAddress]
        [MaxLength(150)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string EmailIcon { get; set; }

        [Required]
        [MaxLength(200)]
        public string Logo { get; set; }
    }
}
