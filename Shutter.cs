using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAutomation
{
    class Shutter : HouseObjectDecorator , ISwitchable 
    {
        private ShutterState currentState;
        public Shutter(string name) : base(name)
        {
            SetCurrentState(new ShutterOn(this));
        }

        public Shutter() : base("")
        {
            SetCurrentState(new ShutterOn(this));
        }

        public override void Add(HouseObject speceificLight)
        {
            throw new NotImplementedException();
        }

        public override string getData()
        {
            throw new NotImplementedException();
        }

        public void PowerOff()
        {
            Console.WriteLine("Shutter is OFF");
        }

        public void PowerOn()
        {
            Console.WriteLine("Shutter is ON");
        }

        public override void Remove(HouseObject speceificLight)
        {
            throw new NotImplementedException();
        }
        public void SetCurrentState(ShutterState currentState)
        {
            this.currentState = currentState;
        }

        public void ButtonClick()
        {
            currentState.ButtonClick();
        }
        public void SensorSignal()
        {
            currentState.SensorSignal();
        }
    }
}
