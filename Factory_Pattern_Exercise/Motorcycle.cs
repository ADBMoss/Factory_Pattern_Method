using System;
namespace Factory_Pattern_Exercise
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public string Drive()
        {
            return "Building a new Motorcycle!";
        }
    }
}
