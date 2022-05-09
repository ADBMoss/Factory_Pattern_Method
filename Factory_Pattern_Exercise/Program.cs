using System;
using System.Collections.Generic;

namespace Factory_Pattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many wheel(s) does the vehicle you want to buy have? : ");
            int answer = int.Parse(Console.ReadLine());
            Console.WriteLine($"{VehicleFactory.GetVehicle(answer)}");
            
        }
    }
}
