using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    public delegate void CarIsBrokenEventHandler(Car car, CarBrokeEventArgs args);


    public class CarBrokeEventArgs : EventArgs
    {
        public string Reason { set; get; }
    }

    public class Car
    {
        public string Number { set; get; }

        public event CarIsBrokenEventHandler CarIsBroken;

        public void SetSpeed(int speed)
        {
            if (speed > 300)
            {
                OnCarBroken("Too fast");
            }
        }

        private void OnCarBroken(string reason)
        {
            if (CarIsBroken != null)
            {
                CarBrokeEventArgs eventArgs = new CarBrokeEventArgs();
                eventArgs.Reason = reason;
                CarIsBroken(this, eventArgs);
            }
        }
    }
}
