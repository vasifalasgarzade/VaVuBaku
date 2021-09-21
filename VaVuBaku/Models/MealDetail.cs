using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaVuBaku.Models
{
    public class MealDetail
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public Meal Meal { get; set; }
        public decimal Weight { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
    }
}
