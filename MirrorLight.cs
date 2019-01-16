using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAutomation
{
    class MirrorLight : HouseObjectDecorator
    {
        public MirrorLight(HouseObjectInterface aHouseObject)
            : base(aHouseObject)
        {

        }
        public override string getDescription()
        {
            return base.getDescription() + ", Mirror light";
        }


        public override double getEnergy()
        {
            return base.getEnergy() + 1.2;
        }

        
    }
}
