using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAutomation
{
    class ShutterOff : ShutterState
    {
        private Shutter _shutter;

        public ShutterOff(Shutter shutter)
        {
            _shutter = shutter;
        }

        public override void ButtonClick()
        {
            _shutter.SetCurrentState(new ShutterOff(_shutter));
            Console.WriteLine("Shutter is turend Off");
        }

        public override void SensorSignal()
        {
            if (true) //sensed a movement
            {
                _shutter.SetCurrentState(new ShutterOff(_shutter));
                Console.WriteLine("Shutter turend off by Sensor");
            }
        }
    }
}
