 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl
{
    internal class Sport : Cars
    {
        public int HorsePower;

        public Sport(int inputHorsePower, string inputCarType, string inputShiftGear, int inputMileage, string inputFuel) : base(inputCarType, inputShiftGear, inputMileage, inputFuel)
        {
            HorsePower = inputHorsePower;
        }
    }
}
