using System;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {
            switch (wheelCount)
            {
                case 2:
                    return new Motorcycle();
                case 3:
                    return new ThreeWheeler();
                case 4:
                    return new Car();
                default:
                    throw new ArgumentException("Invalid wheel count. Supported values are 2, 3, or 4.");
                    return new Car();
            }
        }
    }
}