using System;
namespace FactoryPattern;

public class Car : IVehicle
{
    public Car()
    {
    }

    public void Drive()
    {
        ConsoleLogging.VehicleStartUpDialogue();
        Console.WriteLine("Driving car");
    }
}

