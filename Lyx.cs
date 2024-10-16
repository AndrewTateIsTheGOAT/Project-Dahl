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
        /// <summary>
        /// Konstruktorn 
        /// </summary>
        /// <param name="inputComfortLevel"></param>
        /// <param name="inputCarType"></param>
        /// <param name="inputShiftGear"></param>
        /// <param name="inputMileage"></param>
        /// <param name="inputFuel"></param>
        /// <param name="inputPrice"></param>
        public Lyx(int inputComfortLevel, string inputCarType, string inputShiftGear, int inputMileage, string inputFuel, int inputPrice) : base(inputCarType, inputShiftGear, inputMileage, inputFuel, inputPrice)
        {
            _comfortLevel = inputComfortLevel;
        }

        public int ComfortLevel
        {
            get { return _comfortLevel; }
            set { _comfortLevel = value; }
        }

        
    }

    void blub()
    {

    }
}
