using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaVuBaku.Models
{
    public class ActivityLog
    {
        public long Id { get; set; }
        public int CategoryId { get; set; }//zalda ps3 = 2 azn, zalda ps4 = 3 azn, kabinet her ikisi 5 azn
        public int ActivityId { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime EndTime { get; set; }
        public int RoomId { get; set; }
        public int IsActive { get; set; }
    }
}
