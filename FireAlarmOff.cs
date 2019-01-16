using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAutomation
{
    class FireAlarmOff : FireAlarmState , ICommand
    {
        ISwitchable _switchable;

        public FireAlarmOff(ISwitchable switchable)
        {
            _switchable = switchable;
        }

        public override void ButtonClick()
        {
            _switchable.PowerOff();
        }

        public void Execute()
        {
            this.ButtonClick();
        }

        public override void SensorSignal()
        {
            if (true)//sensed a signal
            {

                this.ButtonClick();
            }
        }
    }
}
