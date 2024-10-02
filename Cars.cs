using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl
{
    internal class Cars
    {
        protected string _carType;
        protected string _shiftGear;
        protected int _mileage;
        protected string _fuel;
        protected int _price;
        

        public Cars(string inputCarType, string inputShiftGear, int inputMileage, string inputFuel, int inputPrice)
        {
            _carType = inputCarType;
            _shiftGear = inputShiftGear;
            _mileage = inputMileage;
            _fuel = inputFuel;
            _price = inputPrice;
        }

        public string CarType
            {  
                get { return _carType; }
                set { _carType = value; }
            }

        public string ShiftGear
        {
            get { return _shiftGear; }
            set { _shiftGear = value; }
        }
        public int Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        public string Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
