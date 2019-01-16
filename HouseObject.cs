using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseAutomation
{
    public abstract class HouseObject
    {
        protected string name;
        public HouseObject(string name)
        {
            this.name = name;
        }
        public abstract void Add(HouseObject speceficHouseObject);
        public abstract void Remove(HouseObject speceificHouseObject);
        public abstract string getData();
        
    }
}
