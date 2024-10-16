using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl
{
    internal class Minivan : Cars
    {
        
        private int _towbarCapacity;

        public Minivan(int inputTowbarCapacity, string inputCarType, string inputShiftGear, int inputMileage, string inputFuel, int inputPrice) : base(inputCarType, inputShiftGear, inputMileage, inputFuel, inputPrice)
        {
            _towbarCapacity = inputTowbarCapacity;
        }

        public int TowBarCapacity
        {
            get { return _towbarCapacity; }
            set { _towbarCapacity = value; }
        }
    }
}

