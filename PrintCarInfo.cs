using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl
{
    internal class PrintCarInfo
    {
        protected string _userCarChoice;
        protected double UserCarChoicePrice;

        public string CarChoice
        {
            get { return _userCarChoice; }
            set { _userCarChoice = value; }
        }
    }
}
