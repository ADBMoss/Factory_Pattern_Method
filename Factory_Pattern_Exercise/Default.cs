using System;
namespace Factory_Pattern_Exercise
{
    public class Default : IVehicle
    {
        public Default()
        {
        }

        public string DefaultResponse()
        {
            return "We do not carry your vehicle!";

        }

        public string Drive()
        {
            return "Nothing to drive.";
        }
    }
}
