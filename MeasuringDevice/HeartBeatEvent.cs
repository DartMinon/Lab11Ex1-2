using System;

namespace MeasuringDevice
{
    public class HeartBeatEventArgs : EventArgs
    {
        public HeartBeatEventArgs()
            : base()
        {
            this.TimeStamp = DateTime.Now;
        }

        public DateTime TimeStamp { get; private set; }
    }
    public delegate void HeartBeatEventHandler
        (object sender, HeartBeatEventArgs args);
}