using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl
{
    internal class Minivan : Cars
    {
        public int TowBarCapacity;

        public Minivan(int inputTowBarCapacity, string inputCarType, string inputShiftGear, int inputMileage, string inputFuel) : base(inputCarType, inputShiftGear, inputMileage, inputFuel)
        {
            TowBarCapacity = inputTowBarCapacity;
        }
    }
}
