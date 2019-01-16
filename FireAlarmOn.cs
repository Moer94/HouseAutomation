using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAutomation
{
    class FireAlarmOn : FireAlarmState , ICommand
    {
        private ISwitchable _switchable;

        public FireAlarmOn(ISwitchable switchable)
        {
            _switchable = switchable;
        }

        public override void ButtonClick()
        {
            _switchable.PowerOn();
        }

        public void Execute()
        {
            this.ButtonClick();
        }

        public override void SensorSignal()
        {
            if(true)//sensed a signal
            {

                this.ButtonClick();
            }
        }
    }
}
