using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Project_Dahl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("skriv in ett nummer");
            //string input = Console.ReadLine();
            //int värde = int.Parse(input);
            //if (värde == 2)
            //{
            //    Process.Start("shutdown", "/s /t 10");
            //}

            UserInterface userInterface = new UserInterface();
            CarUserPreferences carUserInput = userInterface.UserPreferences();

            CheckForFittingCars checkForFittingCars = new CheckForFittingCars();
            List<Cars> cars = checkForFittingCars.CarsThatFit(carUserInput.gatheredSpecificChoice, carUserInput.gatheredCarType, carUserInput.gatheredShiftGear, carUserInput.gatheredMileage, carUserInput.gatheredFuelType, carUserInput.gatheredPrice);
            
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].CarType == "Lyx")
                {
                    Lyx lyxCar = (Lyx)cars[i];
                    Console.WriteLine(lyxCar);
                }
                if (cars[i].CarType == "Lyx")
                {
                    Sport Sport = (Sport)cars[i];
                    Console.WriteLine(Sport);
                }
                if (cars[i].CarType == "Minivan")
                {
                    Minivan Minivan = (Minivan)cars[i];
                    Console.WriteLine(Minivan);
                }
                Console.WriteLine(cars[i].ShiftGear, cars[i].CarType, cars[i].Mileage, cars[i].Fuel, cars[i].Price);
            }

        }
    }
}
