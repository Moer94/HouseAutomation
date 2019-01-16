using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HouseAutomation
{
    class Program
    {
        
        static void Main(string[] args)
        {

                //Composite Pattern
            /*HouseObject Room1 = new Room("Bathroom", 21);
            Room1.Add(new Light("Mirror Light", 20));
            Room1.Add(new Light("Ceiling Light", 10));
            Room1.Add(new Door("Door room J102"));
            Room1.Add(new Shutter("Shutter number 101010"));
            Console.WriteLine(Room1.getData());*/

                //Command Pattern
            /*string argument = "ON";
            
            ISwitchable lamp = new Light();
            ISwitchable alarm = new FireAlarm();
            

            ICommand switchClose = new CloseSwitchCommand(lamp);
            ICommand switchOpen = new OpenswitchCommand(lamp);

            ICommand switchClose2 = new CloseSwitchCommand(alarm);
            ICommand switchOpen2 = new OpenswitchCommand(alarm);

            Switch @switch = new Switch(switchClose, switchOpen);
            Switch @switch2 = new Switch(switchClose2, switchOpen2);


            if (argument == "ON")
            {
                Console.WriteLine("Turning Switch On");
                @switch2.Open();
                Console.WriteLine("Switch is On");
            }
            else if(argument == "OFF")
            {
                //@switch.Close();
                //@switch2.Close();
            }else
            {
                Console.WriteLine("Argumant not valid ,  ON or OFF ");
            }*/


                //State pattern 
            /*Light roofLight = new Light("roof Light");
            roofLight.PowerOn();
            roofLight.SensorSignal();
            roofLight.PowerOff();
            roofLight.SensorSignal();*/


                //Decorater Pattern
            /*HouseObjectInterface objHouseObject = new Room("Bathroom" , 100);

            //Wrp Room instancw with CeilingLight.   
            HouseObjectDecorator objHouseObjectDecorator = new CeilingLight(objHouseObject);

            //Wrap Room instance with MirrorLight instance.   
            objHouseObjectDecorator = new MirrorLight(objHouseObjectDecorator);
            objHouseObjectDecorator = new MirrorLight(objHouseObjectDecorator);
            objHouseObjectDecorator = new MirrorLight(objHouseObjectDecorator);
            objHouseObjectDecorator = new FireAlarm(objHouseObjectDecorator);
            objHouseObjectDecorator = new FireAlarm(objHouseObjectDecorator);
            objHouseObjectDecorator = new FireAlarm(objHouseObjectDecorator);
            Console.Write("House object details: " + objHouseObjectDecorator.getDescription());
            Console.WriteLine("\n\n");
            Console.Write("Total energy consumption: " + objHouseObjectDecorator.getEnergy() + " kWh/d");*/
            Console.Read();
        }
    }
}
