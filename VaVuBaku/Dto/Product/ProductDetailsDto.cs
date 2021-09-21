using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaVuBaku.Dto.Product
{
    public class ProductDetailsDto
    {
        public int ProductId { get; set; }
        public decimal Weight { get; set; }
        public int Quantity { get; set; }
    }
}
