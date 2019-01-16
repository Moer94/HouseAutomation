using System;

namespace HouseAutomation
{
    public class Light : HouseObjectDecorator , ISwitchable 
    {
        string theLight = "The Light";
        protected int ampere;
        private Lightstate currentState;
        public Light(string name):base(name)
        {
            SetCurrentState(new LightOn(this));
        }

        public Light() : base("")
        {
            SetCurrentState(new LightOn(this));
        }

        public Light(string name , int ampere) : base(name)
        {
            this.ampere = ampere;
            SetCurrentState(new LightOn(this));
        }

        public override void Add(HouseObject speceificLight)
        {
            throw new NotImplementedException();
            //this is leaf node
        }

        public override string getData()
        {
            return "Name: " + name + "\tAmpere: " + ampere.ToString("N2");
        }

        public void PowerOff()
        {
            Console.WriteLine((name=="" ? theLight:name)+" is OFF");
            SetCurrentState(new LightOff(this));
        }

        public void PowerOn()
        {
            Console.WriteLine((name == "" ? theLight : name) + " is ON");
            SetCurrentState(new LightOn(this));
        }

        public override void Remove(HouseObject speceificLight)
        {
            throw new NotImplementedException();
            //this is leaf node
        }
        public void SetCurrentState(Lightstate currentState)
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
