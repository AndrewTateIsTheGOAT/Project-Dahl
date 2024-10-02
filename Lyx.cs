using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl
{
    internal class Lyx : Cars
    {
        public int ComfortLevel;

        public Lyx(int inputComfortLevel, string inputCarType, string inputShiftGear, int inputMileage, string inputFuel) : base(inputCarType, inputShiftGear, inputMileage, inputFuel)
        {
            ComfortLevel = inputComfortLevel;
        }
    }
}
