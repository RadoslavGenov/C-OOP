namespace Timer
{
    using System.Threading;

    public delegate void TimerEvent();

    public class TimerDelegate
    {
        private int sec;
        private int ticks;
        private TimerEvent myEvent;

        public TimerDelegate(int _sec, int _ticks, TimerEvent _myEvent)
        {
            this.sec = _sec;
            this.ticks = _ticks;
            this.myEvent = _myEvent;
        }

        public int Sec { get; set; }
        public int Ticks { get; set; }
        public TimerEvent MyEvent { get; set; }

        public void Driver()
        {
            while (ticks != 0)
            {
                Thread.Sleep(sec);
                --ticks;
                myEvent();
            }
        }

    }
}
