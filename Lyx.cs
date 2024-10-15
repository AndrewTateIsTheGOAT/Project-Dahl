using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl
{
    internal class Lyx : Cars
    {
        private int _comfortLevel;
        
        public Lyx(int inputComfortLevel, string inputCarType, string inputShiftGear, int inputMileage, string inputFuel, int inputPrice) : base(inputCarType, inputFuel, inputPrice, inputShiftGear, inputMileage)
        {
            _comfortLevel = inputComfortLevel;
        }

        public int ComfortLevel
        {
            get { return _comfortLevel; }
            set { _comfortLevel = value; }
        }

    }
}
