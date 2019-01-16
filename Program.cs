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
            string argument = "ON";
            /*
            ISwitchable lamp = new Light();
            ISwitchable alarm = new FireAlarm();
            

            ICommand switchClose = new CloseSwitchCommand(lamp);
            ICommand switchOpen = new OpenswitchCommand(lamp);

            ICommand switchClose2 = new CloseSwitchCommand(alarm);
            ICommand switchOpen2 = new OpenswitchCommand(alarm);

            Switch @switch = new Switch(switchClose, switchOpen);
            Switch @switch2 = new Switch(switchClose2, switchOpen2);*/

            //Light roofLight = new Light("roof Light");
            HouseObjectInterface objHouseObject = new Room("Bathroom" , 100);

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
            Console.Write("Total energy consumption: " + objHouseObjectDecorator.getEnergy() + " kWh/d");

            Console.Read();

            if (argument == "ON")
            {
                //Console.WriteLine("Turning Switch On");
                //@switch2.Open();
                //Console.WriteLine("Switch is On");
                /*roofLight.PowerOn();
                roofLight.SensorSignal();
                roofLight.PowerOff();
                roofLight.SensorSignal();*/
            }
            else if(argument == "OFF")
            {
                //@switch.Close();
                //@switch2.Close();
            }else
            {
                Console.WriteLine("Argumant not valid ,  ON or OFF ");
            }
            Console.Read();
        }
    }
}
