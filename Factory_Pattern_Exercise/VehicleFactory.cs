using System;
namespace Factory_Pattern_Exercise
{
    public class VehicleFactory
    {
        public VehicleFactory()
        {
        }

        public static IVehicle GetVehicle(int value)
        {
            return value switch
            {
                1 => new Unicycle(),
                2 => new Motorcycle(),
                3 => new Trike(),
                4 => new Car(),
                18 => new BigRig(),
                _ => new Default(),
            };
        }
    }
}
