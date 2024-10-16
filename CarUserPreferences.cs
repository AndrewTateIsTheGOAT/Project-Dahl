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

        /// <summary>
        /// Konstruktorn returnerar en instans av klassen CarUserPreferences
        /// </summary>
        /// <param name="inputGatheredSpecificChoice">Den sparar ner användarens input om en specification till den specifika biltypen den valt</param>
        /// <param name="inputGatheredCarType">sparar ner värdet av användarens input om biltyp</param>
        /// <param name="inputGatheredShiftGear">sparar ner värdet av användarens input om ShiftGear</param>
        /// <param name="inputGatheredFuelType">sparar ner värdet av användarens input om FuelType</param>
        /// <param name="inputGatheredMileage">sparar ner värdet av användarens input om Mileage</param>
        /// <param name="inputGatheredPrice">sparar ner värdet av användarens input om Price</param>
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
