using System;

namespace FactoryPattern
{
    public class Program

    {
        public static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;

            do
            {
                Console.WriteLine("Enter the amount of tires for your vehicle: ");
                input = int.TryParse(Console.ReadLine(), out wheelCount);
            } while (input == false);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}