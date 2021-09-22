using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VavuBakuMVCcore.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Photo { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:#.##}")]
        public double Price { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        public FoodCategory FoodCategory { get; set; }
        public int FoodCategoryId { get; set; }
    }
}
