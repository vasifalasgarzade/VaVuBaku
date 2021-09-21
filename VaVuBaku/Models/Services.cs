using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaVuBaku.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public decimal Price { get; set; }
        public CategoryType Category { get; set; }
        public int CategoryId { get; set; }

    }
}
