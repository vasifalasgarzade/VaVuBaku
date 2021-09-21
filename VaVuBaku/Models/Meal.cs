using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VaVuBaku.Models
{
    public class Meal
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        //public List<Product> Products { get; set; }
        public List<MealDetail> MealDetails { get; set; }
    }
}
