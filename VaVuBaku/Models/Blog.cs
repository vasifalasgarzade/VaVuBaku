using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VaVuBaku.Models
{
    public class Blog
    {
        
        public int Id { get; set; }

        [Required]
        public string Photo { get; set; }
     
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MaxLength(150)]
        public string Tittle { get; set; }

    }
}
