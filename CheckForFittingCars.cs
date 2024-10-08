    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl
{
    internal class CheckForFittingCars
    {
        public List<Cars> CarList = new List<Cars>
        {
            new Cars("Lyx", "Manual", 5000, "Diesel", 6000),
            new Cars("Lyx", "Automat", 5000, "Diesel", 5500),
            new Cars("Lyx", "Manual", 5000, "Bensin", 4500),
            new Cars("Lyx", "Automat", 5000, "Bensin", 5000),
            new Cars("Lyx", "Manual", 10000, "Diesel", 4500),
            new Cars("Lyx", "Automat", 10000, "Diesel", 4500),
            new Cars("Lyx", "Manual", 10000, "Bensin", 4000),
            new Cars("Lyx", "Automat", 10000, "Bensin", 4000),
            new Cars("Lyx", "Manual", 15000, "Diesel", 3500),
            new Cars("Lyx", "Automat", 15000, "Diesel", 3500),
            new Cars("Lyx", "Manual", 15000, "Bensin", 3500),
            new Cars("Lyx", "Automat", 15000, "Bensin", 3500),
            new Cars("Minivan", "Automat", 5000, "Diesel", 2000),
            new Cars("Minivan", "Manual", 5000, "Diesel", 2000),
            new Cars("Minivan", "Automat", 5000, "Bensin", 2000),
            new Cars("Minivan", "Manual", 5000, "Bensin", 2000),
            new Cars("Minivan", "Automat", 10000, "Diesel", 1500),
            new Cars("Minivan", "Manual", 10000, "Diesel", 1500),
            new Cars("Minivan", "Automat", 10000, "Bensin", 1500),
            new Cars("Minivan", "Manual", 10000, "Bensin", 1500),
            new Cars("Minivan", "Automat", 15000, "Diesel", 1000),
            new Cars("Minivan", "Manual", 15000, "Diesel", 1000),
            new Cars("Minivan", "Automat", 15000, "Bensin", 1000),
            new Cars("Minivan", "Manual", 15000, "Bensin", 1000),
            new Cars("Sport", "Manual", 5000, "Diesel", 5000),
            new Cars("Sport", "Automat", 5000, "Diesel", 5000),
            new Cars("Sport", "Manual", 5000, "Bensin", 5500),
            new Cars("Sport", "Automat", 5000, "Bensin", 5500),
            new Cars("Sport", "Manual", 10000, "Diesel", 6000),
            new Cars("Sport", "Automat", 10000, "Diesel", 6000),
            new Cars("Sport", "Manual", 10000, "Bensin", 6500),
            new Cars("Sport", "Automat", 10000, "Bensin", 6500),
            new Cars("Sport", "Manual", 15000, "Diesel", 7000),
            new Cars("Sport", "Automat", 15000, "Diesel", 7500),
            new Cars("Sport", "Manual", 15000, "Bensin", 7500),
            new Cars("Sport", "Automat", 15000, "Bensin", 7000),

        };
        public int _basePrice;
        
        public List<Cars> CarsThatFit(string inputCarType, string inputShiftGear, int inputMileage, string inputFuel)
        {
            List<Cars> FittingCars = new List<Cars>
            {

            };
            for(int i = 0; i < CarList.Count; i++)
            {
                if (CarList[i].CarType == inputCarType && CarList[i].ShiftGear == inputShiftGear && CarList[i].Mileage == inputMileage && CarList[i].Fuel == inputFuel)
                {
                    FittingCars.Add(CarList[i]);
                }
            }
            return CarList;            
        }
    }
}
                                                                      