using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAutomation
{
    class CeilingLight : HouseObjectDecorator 
    {
        public CeilingLight(HouseObjectInterface aHouseObject)
            :base(aHouseObject)
        {

        }

        public override string getDescription()
        {
            return base.getDescription() + ", Ceiling light";
        }

        public override double getEnergy()
        {
            return base.getEnergy() + 1.4;
        }
    }
}
