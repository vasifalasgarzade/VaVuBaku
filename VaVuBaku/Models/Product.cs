using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaVuBaku.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal InPrice { get; set; }
        public decimal Weight { get; set; }
        public int Quantity { get; set; }
        public decimal OutPrice { get; set; }
        public CategoryType Category { get; set; }
        public int CategoryId { get; set; }
        public int IsServed { get; set; }
        //public List<Meal> Meals { get; set; }

    }
}
