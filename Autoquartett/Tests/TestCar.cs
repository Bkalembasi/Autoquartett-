using System;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace Autoquartett.Tests
{
    public class TestCar
    {
        public static void Main(string[] args)
        {
            Car mazda = new Car();
            mazda.setBrand("Mazda");
            mazda.setModel("RX-8");
            mazda.setCarClass("Sportwagen");
            mazda.SetAcceleration(6.5);
            mazda.SetCcm(1308);
            mazda.SetPs(231);
            mazda.SetConsumption(11.4);
            mazda.SetPiston(2);
            mazda.SetKmPerH(240);
            
            // mazda.GetCardInformation();
            Console.Write(mazda.ToString());
            
            
            Car jaguar = new Car();
            jaguar.setBrand("Jaguar");
            jaguar.setModel("S-Type");
            jaguar.setCarClass("Limousine");
            jaguar.SetAcceleration(8.6);
            jaguar.SetCcm(2720);
            jaguar.SetPs(207);
            jaguar.SetConsumption(8.6);
            jaguar.SetPiston(6);
            jaguar.SetKmPerH(227);
            
            Console.Write(jaguar.ToString());
        }
    }
}