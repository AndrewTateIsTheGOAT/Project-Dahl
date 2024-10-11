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

        public Lyx(int inputComfortLevel, string inputCarType, string inputShiftGear, int inputMileage, string inputFuel, int inputPrice) : base(inputCarType, inputShiftGear, inputMileage, inputFuel, inputPrice)
        {
            ComfortLevel = inputComfortLevel;
        }
        //public int ComfortLevel
        //{
        //    get { return ComfortLevel; }
        //    set { ComfortLevel = value; }
        //}
    }
}
