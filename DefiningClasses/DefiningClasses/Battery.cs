using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    class Battery
    {
        enum BatterType { LiIon, NiMH, NiC };
        private string batteryModel;
        private int hoursIdle;
        private int hoursTalk;
        public string BatteryModel { get; set; }
        public int HoursIdle { get; set; }
        public int HoursTalk { get; set; }
        public Battery(string _batteryModel, int _hoursIdle, int _hoursTalk)
        {
            this.batteryModel = _batteryModel;
            this.hoursIdle = _hoursIdle;
            this.hoursTalk = _hoursTalk;
        }
    }
}
