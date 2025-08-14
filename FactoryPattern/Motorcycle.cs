using System;
namespace FactoryPattern;

public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }
        public void Drive()
        {
            ConsoleLogging.VehicleStartUpDialogue();
            Console.WriteLine("Driving motorcycle");
            Console.WriteLine("skerrrrrttt");
        }
}