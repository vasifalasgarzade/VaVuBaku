using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaVuBaku.Dto.Product
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal InPrice { get; set; }
        public decimal Weight { get; set; }
        public int Quantity { get; set; }
        public decimal OutPrice { get; set; }
        public int CategoryId { get; set; }
    }
}
