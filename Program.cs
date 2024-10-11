using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();
            Cars good = userInterface.UserPreferences();
            CheckForFittingCars checkForFittingCars = new CheckForFittingCars();
            List<Cars> autism = checkForFittingCars.CarsThatFit(good.CarType, good.ShiftGear, good.Mileage, good.Fuel);
            for (int i = 0; i < autism.Count; i++)
            {
                Console.WriteLine(autism[i]);
            }
            //checkForFIttingCars.CarsThatFit();
        }
    }
}
