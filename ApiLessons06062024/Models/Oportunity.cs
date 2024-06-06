using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Oportunity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string OutbreakLevel { get; set; }
        public int HoursQty { get; set; }
        public int ErrorsQty { get; set; }
        public long LearningLevel { get; set; }
        public long SleepingHours { get; set; }
        public int HoursOff { get; set; }
    }
}
