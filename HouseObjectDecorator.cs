using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAutomation
{
    public abstract class HouseObjectDecorator : HouseObject, HouseObjectInterface
    {
        private HouseObjectInterface _HouseObject;
  
        public HouseObjectDecorator(HouseObjectInterface houseObject) : base("")
        {
            this._HouseObject = houseObject;
        }

        public HouseObjectDecorator(string name) : base(name)
        {
            this.name = name;
        }

        public override void Add(HouseObject speceificHouseObj)
        {
            throw new NotImplementedException();
        }

        public override void Remove(HouseObject speceificHouseObject)
        {
            throw new NotImplementedException();
        }

        public override string getData()
        {
            throw new NotImplementedException();
        }

        public virtual string getDescription()
        {
            return this._HouseObject.getDescription();
        }


        public virtual double getEnergy()
        {
            return this._HouseObject.getEnergy();
        }

        
    }
}
