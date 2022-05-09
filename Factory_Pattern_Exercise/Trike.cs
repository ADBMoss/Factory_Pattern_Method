using System;
namespace Factory_Pattern_Exercise
{
    public class Trike : IVehicle
    {
        public Trike()
        {
        }

        public string Drive()
        {
            return "Building a new Trike!";
        }
    }
}
