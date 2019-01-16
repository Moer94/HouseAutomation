using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAutomation
{
    public class FireAlarm : HouseObjectDecorator , ISwitchable
    {

        
        public FireAlarm(HouseObjectInterface aHouseObject)
            : base(aHouseObject)
        {

        }
        public FireAlarm(string name) : base(name)
        {
        }

        public FireAlarm() : base("")
        {
        }

        public override string getData()
        {
            return "Name: " + name ;
        }

        public void PowerOff()
        {
            Console.WriteLine("The Alarm is OFF");
        }

        public void PowerOn()
        {
            Console.WriteLine("The Alarm is ON");
        }

        public override string getDescription()
        {
            return base.getDescription() + ", Fire alarm";
        }

        public override double getEnergy()
        {
            return base.getEnergy() + 0.2;
        }
    }
}
