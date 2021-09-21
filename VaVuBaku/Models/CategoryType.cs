using System.Collections.Generic;

namespace VaVuBaku.Models
{
    public class CategoryType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public List<Service> Services { get; set; }
    }
}