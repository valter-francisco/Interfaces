using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterfacesEx1
{
    public class Car : IVehicle
    {
        public int totalFuel { get; set; }

        public void Drive(int totalFuel)
        {
            if (totalFuel < 0)
            {
                Random consume = new Random();
                totalFuel = totalFuel - consume.Next(1, totalFuel + 1);

                Console.WriteLine("The car is driving!");
            }
            else
            {
                Console.WriteLine("Please, refuel the car");
            }
        }

        public bool Refuel(int gasoline)
        {
            int totalFuel = 0;
            totalFuel = totalFuel + gasoline;

            return true;
        }



    }
}
