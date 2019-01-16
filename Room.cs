using System;
using System.Collections.Generic;
using System.Text;

namespace HouseAutomation
{
    class Room : HouseObjectDecorator , ISwitchable
    {
        protected int size;
        List<HouseObject> lstRoom = new List<HouseObject>();
        public Room(string name ,int size) : base(name)
        {
            this.size = size;
        }
        public override void Add(HouseObject specificHouseObject)
        {
            lstRoom.Add(specificHouseObject);
        }
        public override void Remove(HouseObject specificHouseObject)
        {
            lstRoom.Remove(specificHouseObject);
        }
        public override string getData()
        {
            Console.WriteLine("RoomName: " + name + " " + "Roomsize: " + size + "m^2\n");
            StringBuilder sbRooms = new StringBuilder();
            foreach(HouseObject room in lstRoom)
            {
                //sbRooms.Append("RoomName: " + name + " " + "Roomsize: " + size + "m^2\n");
                sbRooms.Append(room.getData() + "\n");
            }
            return sbRooms.ToString();
        }

        public void PowerOn()
        {
            throw new NotImplementedException();
        }

        public void PowerOff()
        {
            throw new NotImplementedException();
        }
        public override string getDescription()
        {
            return "Room";
        }

        public override double getEnergy()
        {
            return 0;
        }
    }
}
