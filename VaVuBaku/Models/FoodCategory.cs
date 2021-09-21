using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VaVuBaku.Models
{
    public class FoodCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        public byte Order { get; set; }

        public ICollection<Food> Foods { get; set; }
    }
}
