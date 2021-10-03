using InterfacesEx1;
using System;
using System.Threading;

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

        /// <summary>
        /// funtion used to verify if the user input of fuel is inside the tank limits
        /// </summary>
        /// <param name="fuelinp">used after conversion from the user input</param>
        /// <returns>returns true if the fuel value is inside the tank limits</returns>
        public static bool FuelInputQauntityVerification (int fuelinp)
        {
            if (fuelinp > 0 && fuelinp <= 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// function used after the car consumes all the fuel to ask if the user wants to do another cycle or if they want to quit
        /// </summary>
        public static void QuitOrKeepDriving()
        {
            Console.WriteLine("You want to refuel or quit? \n1 - Refuel \n2 - Quit");

            string refuelOrQuit = Console.ReadLine();

            switch (refuelOrQuit)
            {
                case "1":
                    break;

                case "2":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please insert a valid input. . .");
                    break;
            }
        }


        static void Main(string[] args)
        {
            Car car = new Car();
            car.totalFuel = 0;

            Console.WriteLine("Exercise 1");

            do
            {
                bool fuelInput = false;
                do
                {
                    fuelInput = false;
                    string gasolineInp = AskForFuel();
                    bool convertToInt = TryConvertFuelToInt(gasolineInp);
                    int gasoline;

                    if (convertToInt == true)
                    {
                        gasoline = ConvertFuelToInt(gasolineInp);
                    }
                    else
                    {
                        continue;
                    }

                    bool fuelQuantity = FuelInputQauntityVerification(gasoline);

                    if (fuelQuantity == true)
                    {
                        car.Refuel(gasoline);
                        fuelInput = true;
                    }
                    else
                    {
                        continue;
                    }
                }
                while (fuelInput == false);

                while (car.totalFuel > 0)
                {
                    car.Drive(car.totalFuel);
                }

                QuitOrKeepDriving();

            }
            while (true);

           

        }

    }
}
