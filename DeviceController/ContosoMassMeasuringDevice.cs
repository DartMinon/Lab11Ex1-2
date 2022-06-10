using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using DeviceControl;

namespace Contoso.MeasuringDevices
{
    class MassMeasuringDevice : IControllableDevice
    {
        Random random;
        public MassMeasuringDevice()
        {
            random = new Random();
        }
        public void StartDevice()
        {
            // Start the device.
        }

        public void StopDevice()
        {
            // Stop the device.
        }
        public int GetLatestMeasure()
        {
            Thread.Sleep(random.Next(5000));
            return random.Next(1390);
        }
    }
}
