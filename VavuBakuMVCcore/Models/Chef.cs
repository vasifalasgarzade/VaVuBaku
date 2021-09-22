using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VavuBakuMVCcore.Models
{
    public class Chef
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string Photo { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Role { get; set; }
    }
}
