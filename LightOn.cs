using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAutomation
{
    class LightOn : Lightstate
    {
        private Light _lightroom;

        public LightOn(Light lightroom)
        {
            this._lightroom = lightroom;
        }
        

        public override void ButtonClick()
        {
            _lightroom.SetCurrentState(new LightOn(_lightroom));
            Console.WriteLine("Light is turend On by button");
        }

        public override void SensorSignal()
        {
            if (true) //sensed a movement
            {
                _lightroom.SetCurrentState(new LightOn(_lightroom));
                Console.WriteLine("Already On , so sensor is asleep");
            }
        }
    }
}
