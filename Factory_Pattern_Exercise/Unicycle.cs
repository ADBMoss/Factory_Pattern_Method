using System;
namespace Factory_Pattern_Exercise
{
    public class Unicycle : IVehicle
    {
        public Unicycle()
        {
        }

        public string Drive()
        {
            return "Building a new Unicycle!";
        }
    }
}
