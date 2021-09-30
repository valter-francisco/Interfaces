using InterfacesEx1;
using System;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// function used to ask for gasoline whenever the totalFuel reaches 0
        /// </summary>
        /// <returns> returns a string used by TryConvertFuelToInt to verify if it can fill the tank</returns>
        public static string AskForFuel()
        {
            Console.WriteLine("Please insert a number to refuel your car (has to be between 1 and 30)!");
            Console.WriteLine();

            string fuelInput = Console.ReadLine();

            return fuelInput;
        }

        /// <summary>
        /// function used to verify if the fuelInput can be converted to an int
        /// </summary>
        /// <param name="fuelInput"> gets value from the funtion AskForFuel</param>
        /// <returns> returns true if the number can be converted to an int</returns>
        public static bool TryConvertFuelToInt (string fuelInput)
        {
            int fuelInp;
            if (Int32.TryParse(fuelInput, out fuelInp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// this funciton converts the user input to int
        /// used only after TryConvertFuelToInt
        /// </summary>
        /// <param name="fuelInput">input received from the user</param>
        /// <returns>returns an int that need to be verified if its between the tank capacity</returns>
        public static int ConvertFuelToInt (string fuelInput)
        {
            int fuelInp = Convert.ToInt32(fuelInput);
            return fuelInp;
        }




        static void Main(string[] args)
        {
            Car car = new Car();

            car.totalFuel = 0;

            car.Drive(car.totalFuel);

           

        }

    }
}
