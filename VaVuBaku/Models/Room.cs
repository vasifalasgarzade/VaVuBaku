using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaVuBaku.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int IsOpen { get; set; }
        public int IsEmpty { get; set; }
        public int Deposit { get; set; }
        public int Capacity { get; set; }
        public string Picture { get; set; }

    }
}
