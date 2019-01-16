using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAutomation
{
    class Door : HouseObjectDecorator, ISwitchable
    {
        string info;
        public Door(): base("")
        {
        }

        public Door(string name) : base(name)
        {
        }

        public Door(string name, string info) : base(name)
        {
            this.info = info;
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
            Console.WriteLine("The Door is locked");
        }

        public void PowerOn()
        {
            Console.WriteLine("The Door is unlocked");
        }

        public override void Remove(HouseObject speceificLight)
        {
            throw new NotImplementedException();
        }
        public override string getDescription()
        {
            return "Door";
        }

        public override double getEnergy()
        {
            return 0;
        }
    }
}
