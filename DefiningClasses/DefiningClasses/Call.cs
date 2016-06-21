using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Call
    {
        private DateTime date = new DateTime();
        private int time;
        private int dialledNumber;
        private int duration;
        public DateTime Date { get; set; }
        public int Time { get; set; }
        public int DialledNumber { get; set; }
        public int Duration { get; set; }
    }
}
