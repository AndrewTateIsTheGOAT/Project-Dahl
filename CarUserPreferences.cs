using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl
{
    internal class CarUserPreferences
    {
        public string gatheredCarType;
        public string gatheredFuelType;
        public string gatheredShiftGear;
        public int gatheredSpecificChoice;
        public int gatheredMileage;
        public int gatheredPrice;

        public CarUserPreferences(int inputGatheredSpecificChoice, string inputGatheredCarType, string inputGatheredShiftGear, string inputGatheredFuelType, int inputGatheredMileage, int inputGatheredPrice)
        {
            gatheredCarType = inputGatheredCarType;
            gatheredFuelType = inputGatheredFuelType;
            gatheredMileage = inputGatheredMileage;
            gatheredPrice = inputGatheredPrice;
            gatheredSpecificChoice = inputGatheredSpecificChoice;
            gatheredShiftGear = inputGatheredShiftGear;
        }
    }
}
