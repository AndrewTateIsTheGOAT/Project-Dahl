using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl
{
    internal class Sport : Cars
    {
        
        private int _horsePower;

        public Sport(int inputHorsePower, string inputCarType, string inputShiftGear, int inputMileage, string inputFuel, int inputPrice) : base(inputCarType, inputFuel, inputPrice, inputShiftGear, inputMileage)
        {
            _horsePower = inputHorsePower;
        }
        public int HorsePower
        {
            get { return _horsePower; }
            set { _horsePower = value; }
        }
    }
}

