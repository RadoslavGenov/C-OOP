using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class GSM
    {
        private static readonly GSM iphone4S = new GSM("IPhone", "Apple", 600, "Rado", new Battery("LiIon", 60, 60), new Display(500, 52000));
        private List<Call> calls = new List<Call>();
        private string model;
        private string manufacturer;
        private int price;
        private string owner;
        private Battery battery;
        private Display display;

        public GSM IPhone4S { get; }
        public List<Call> Calls
        {
            get
            {
                return new List<Call>(this.calls);
            }
        }

        public GSM(string _model, string _manufacturer)
        {
            this.model = _model;
            this.manufacturer = _manufacturer;
            this.price = 0;
            this.owner = null;
            this.battery = new Battery(null, 0, 0);
            this.display = new Display(0, 0);
        }
        public GSM(string _model, string _manufacturer, int _price, string _owner, Battery _battery, Display _display)
        {
            this.model = _model;
            this.manufacturer = _manufacturer;
            this.price = _price;
            this.owner = _owner;
            this.battery = _battery;
            this.display = _display;
        }

        public override string ToString()
        {
            return string.Format(@"Model: {0}
Manufacturer: {1}
Price: {2}
Owner: {3}
Battery Model: {4}
Hours Idle: {5}
Hours Talk: {6}
Display Size: {7}
Display Colors: {8}",
                                   model, manufacturer,
                                   price, owner, battery.BatteryModel,
                                   battery.HoursIdle, battery.HoursTalk,
                                   display.Size, display.Colors);
        }
    }
}
