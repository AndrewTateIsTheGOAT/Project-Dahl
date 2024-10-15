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
            Cars good = userInterface.UserPreferences();
            CheckForFittingCars fitCars = new UserInterface.UserPreferences();

            CheckForFittingCars checkForFittingCars = new CheckForFittingCars();
            List<Cars> autism = checkForFittingCars.CarsThatFit(fitCars.spec, good.CarType, good.ShiftGear, good.Mileage, good.Fuel, good.Price);
            for (int i = 0; i < autism.Count; i++)
            {
                Console.WriteLine(autism[i]);
            }
            checkForFIttingCars.CarsThatFit();
        }
    }
}
