using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAutomation
{
    abstract class FireAlarmState
    {
        public abstract void ButtonClick();
        public abstract void SensorSignal();
    }
}
