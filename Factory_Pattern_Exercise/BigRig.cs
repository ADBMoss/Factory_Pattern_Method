using System;
namespace Factory_Pattern_Exercise
{
    public class BigRig : IVehicle
    {
        public BigRig()
        {
        }

        public string Drive()
        {
            return "Building a new BigRig!";
        }

    }
}
