namespace Event
{
    using System;
    using System.Threading;

    public delegate void IntervalEvent(object me, EventArgs e);

    class Event
    {
        private int interval;
        private int ticks;

        public event IntervalEvent myEvent;

        public Event(int _interval, int _ticks)
        {
            this.interval = _interval;
            this.ticks = _ticks;
        }

        public int Interval { get; set; }
        public int Ticks { get; set; }

        protected void Tick()
        {
            if (this.myEvent != null)
            {
                myEvent(this, null);
            }
        }

        public void Drive()
        {
            Thread myThread = new Thread(() =>
            {
                while (this.ticks != 0)
                {
                    Thread.Sleep(this.interval);
                    Tick();
                }
            });

            myThread.Start();
        }
    }
}
