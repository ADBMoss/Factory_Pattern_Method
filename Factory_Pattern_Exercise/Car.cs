using System;
namespace Factory_Pattern_Exercise
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public string Drive()
        {
            return "Building a new Car!";
        }
    }
}
