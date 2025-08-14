using System;
namespace FactoryPattern;

public class ThreeWheeler : IVehicle
{
    public ThreeWheeler()
    {
    }
    public void Drive()
    {
        ConsoleLogging.VehicleStartUpDialogue();
        Console.WriteLine("Driving on three wheels!");
    }
}