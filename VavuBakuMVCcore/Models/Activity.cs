using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VavuBakuMVCcore.Models
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Photo { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        public DateTime ActivityDate { get; set; }
    }
}
