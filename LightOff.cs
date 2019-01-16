using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAutomation
{
    class LightOff : Lightstate
    {
        private Light _lightroom;

        public LightOff(Light lightroom)
        {
            this._lightroom = lightroom;
        }

        public override void ButtonClick()
        {
            _lightroom.SetCurrentState(new LightOff(_lightroom));
            Console.WriteLine("Light is turend Off by button click");
        }

        public override void SensorSignal()
        {
            if (true) //sensed a movement
            {
                Console.WriteLine("Sensed a Movement , so Lights is going to be on");
                _lightroom.SetCurrentState(new LightOn(_lightroom));
            }
        }
    }
}
