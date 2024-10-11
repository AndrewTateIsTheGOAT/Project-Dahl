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
            new Lyx(1, "Lyx", "Manuell", 5000, "Diesel", 6000),
            new Lyx(1, "Lyx", "Manuell", 5000, "Diesel", 5500),
            new Lyx(1, "Lyx", "Automat", 5000, "Bensin", 4500),
            new Lyx(1, "Lyx", "Automat", 5000, "Diesel", 5000),
            new Lyx(1, "Lyx", "Manuell", 10000, "Diesel", 6000),
            new Lyx(1, "Lyx", "Manuell", 10000, "Diesel", 5500),
            new Lyx(1, "Lyx", "Automat", 10000, "Bensin", 4500),
            new Lyx(1, "Lyx", "Automat", 10000, "Diesel", 5000),
            new Lyx(2, "Lyx", "Manuell", 5000, "Bensin", 4500),
            new Lyx(2, "Lyx", "Manuell", 5000, "Diesel", 5000),
            new Lyx(2, "Lyx", "Automat", 5000, "Bensin", 5000),
            new Lyx(2, "Lyx", "Automat", 5000, "Diesel", 5000),
            new Lyx(2, "Lyx", "Manuell", 10000, "Bensin", 4500),
            new Lyx(2, "Lyx", "Manuell", 10000, "Diesel", 5000),
            new Lyx(2, "Lyx", "Automat", 10000, "Bensin", 5000),
            new Lyx(2, "Lyx", "Automat", 10000, "Diesel", 5000),
            new Lyx(3, "Lyx", "Manuell", 5000, "Bensin", 4500),
            new Lyx(3, "Lyx", "Automat", 5000, "Diesel", 5000),
            new Lyx(3, "Lyx", "Manuell", 5000, "Diesel", 5000),
            new Lyx(3, "Lyx", "Automat", 5000, "Bensin", 5000),
            new Lyx(3, "Lyx", "Manuell", 10000, "Bensin", 4500),
            new Lyx(3, "Lyx", "Automat", 10000, "Diesel", 5000),
            new Lyx(3, "Lyx", "Manuell", 10000, "Diesel", 5000),
            new Lyx(3, "Lyx", "Automat", 10000, "Bensin", 5000),
            new Minivan(1, "Minivan", "Automat", 5000, "Diesel", 2000),
            new Minivan(1, "Minivan", "Manuell", 5000, "Diesel", 2000),
            new Minivan(1, "Minivan", "Automat", 5000, "Bensin", 2000),
            new Minivan(1, "Minivan", "Manuell", 5000, "Bensin", 2000),
            new Minivan(1, "Minivan", "Automat", 10000, "Diesel", 2000),
            new Minivan(1, "Minivan", "Manuell", 10000, "Diesel", 2000),
            new Minivan(1, "Minivan", "Automat", 10000, "Bensin", 2000),
            new Minivan(1, "Minivan", "Manuell", 10000, "Bensin", 2000),
            new Minivan(2, "Minivan", "Automat", 5000, "Diesel", 2000),
            new Minivan(2, "Minivan", "Manuell", 5000, "Diesel", 2000),
            new Minivan(2, "Minivan", "Automat", 5000, "Bensin", 2000),
            new Minivan(2, "Minivan", "Manuell", 5000, "Bensin", 2000),
            new Minivan(2, "Minivan", "Automat", 10000, "Diesel", 2000),
            new Minivan(2, "Minivan", "Manuell", 10000, "Diesel", 2000),
            new Minivan(2, "Minivan", "Automat", 10000, "Bensin", 2000),
            new Minivan(2, "Minivan", "Manuell", 10000, "Bensin", 2000),
            new Minivan(3, "Minivan", "Automat", 5000, "Diesel", 2000),
            new Minivan(3, "Minivan", "Manuell", 5000, "Diesel", 2000),
            new Minivan(3, "Minivan", "Automat", 5000, "Bensin", 2000),
            new Minivan(3, "Minivan", "Manuell", 5000, "Bensin", 2000),
            new Minivan(3, "Minivan", "Automat", 10000, "Diesel", 2000),
            new Minivan(3, "Minivan", "Manuell", 10000, "Diesel", 2000),
            new Minivan(3, "Minivan", "Automat", 10000, "Bensin", 2000),
            new Minivan(3, "Minivan", "Manuell", 10000, "Bensin", 2000),
            new Sport(200, "Sport", "Manuell", 5000, "Diesel", 5000),
            new Sport(200, "Sport", "Automat", 5000, "Diesel", 5000),
            new Sport(200,"Sport", "Manuell", 5000, "Bensin", 5500),
            new Sport(200, "Sport", "Automat", 5000, "Bensin", 5500),
            new Sport(200, "Sport", "Manuell", 10000, "Diesel", 6000),
            new Sport(200, "Sport", "Automat", 10000, "Diesel", 6000),
            new Sport(200, "Sport", "Manuell", 10000, "Bensin", 6500),
            new Sport(200, "Sport", "Automat", 10000, "Bensin", 6500),
            new Sport(400, "Sport", "Manuell", 5000, "Diesel", 5000),
            new Sport(400, "Sport", "Automat", 5000, "Diesel", 5000),
            new Sport(400,"Sport", "Manuell", 5000, "Bensin", 5500),
            new Sport(400, "Sport", "Automat", 5000, "Bensin", 5500),
            new Sport(400, "Sport", "Manuell", 10000, "Diesel", 6000),
            new Sport(400, "Sport", "Automat", 10000, "Diesel", 6000),
            new Sport(400, "Sport", "Manuell", 10000, "Bensin", 6500),
            new Sport(400, "Sport", "Automat", 10000, "Bensin", 6500),
            new Sport(600, "Sport", "Manuell", 5000, "Diesel", 5000),
            new Sport(600, "Sport", "Automat", 5000, "Diesel", 5000),
            new Sport(600,"Sport", "Manuell", 5000, "Bensin", 5500),
            new Sport(600, "Sport", "Automat", 5000, "Bensin", 5500),
            new Sport(600, "Sport", "Manuell", 10000, "Diesel", 6000),
            new Sport(600, "Sport", "Automat", 10000, "Diesel", 6000),
            new Sport(600, "Sport", "Manuell", 10000, "Bensin", 6500),
            new Sport(600, "Sport", "Automat", 10000, "Bensin", 6500),



        };
        public int _basePrice;
        
        public List<Cars> CarsThatFit(int inputSpecificChoice, string inputCarType, string inputShiftGear, int inputMileage, string inputFuel, int inputPrice)
        {
            List<Cars> FittingCars = new List<Cars>
            {

            };
            for(int i = 0; i < CarList.Count; i++)
            {
                if(CarList[i].CarType == "Lyx")
                {
                    Lyx lyxCar = (Lyx)CarList[i];
                    if (lyxCar.ComfortLevel == inputSpecificChoice && CarList[i].CarType == inputCarType && CarList[i].ShiftGear == inputShiftGear && CarList[i].Mileage == inputMileage && CarList[i].Fuel == inputFuel && CarList[i].Price == inputPrice)
                    {
                        FittingCars.Add(CarList[i]);
                    }
                }
                if(CarList[i].CarType == "Sport")
                {
                    Sport sportCar = (Sport)CarList[i];
                    if (sportCar.HorsePower == inputSpecificChoice && CarList[i].CarType == inputCarType && CarList[i].ShiftGear == inputShiftGear && CarList[i].Mileage == inputMileage && CarList[i].Fuel == inputFuel && CarList[i].Price == inputPrice)
                    {
                        FittingCars.Add(CarList[i]);
                    }
                }
                if(CarList[i].CarType == "Minivan")
                {
                    Minivan minivanCar = (Minivan)CarList[i];
                    if (minivanCar.TowBarCapacity == inputSpecificChoice && CarList[i].CarType == inputCarType && CarList[i].ShiftGear == inputShiftGear && CarList[i].Mileage == inputMileage && CarList[i].Fuel == inputFuel && CarList[i].Price == inputPrice)
                    {
                        FittingCars.Add(CarList[i]);
                    }
                }
            }
            return FittingCars;            
        }
    }
}
                                                                      