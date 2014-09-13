using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tick_Tock_Time.Model
{
    public class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int HalfPast { get; set; }
        public int Quarters { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
