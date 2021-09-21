using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VaVuBaku.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Photo { get; set; }

        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
    }
}
