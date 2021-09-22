using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VavuBakuMVCcore.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Icon { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(350)]
        public string Description { get; set; }
    }
}
