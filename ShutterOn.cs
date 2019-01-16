using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAutomation
{
    class ShutterOn : ShutterState
    {
        private Shutter _shutter;

        public ShutterOn(Shutter shutter)
        {
            _shutter = shutter;
        }

        public override void ButtonClick()
        {
            _shutter.SetCurrentState(new ShutterOn(_shutter));
            Console.WriteLine("Shutter is turend On");
        }

        public override void SensorSignal()
        {
            if (true) //sensed a movement
            {
                _shutter.SetCurrentState(new ShutterOn(_shutter));
                Console.WriteLine("Shutter turend on by Sensor");
            }
        }
    }
}
