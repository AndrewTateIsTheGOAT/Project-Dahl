using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl
{
    internal class ChangePriseBaseOnAge
    {

        /// <summary>
        /// Metoden ska använda användarens ålderinput och sen basera priset på det eftersom försäkringen blir dyrare om personen är en ung förare eller en gammal förare. 
        /// </summary>
        /// <param name="UserAge"></param>
        /// <param name="_userCarChoice"></param>
        /// <param name="UserCarChoicePrice"></param>
        /// <returns></returns>
        public double ChangePrice(int UserAge, string _userCarChoice, double UserCarChoicePrice)
        {
            if(UserAge < 25 && _userCarChoice == "Lyx")
            {
                UserCarChoicePrice = UserCarChoicePrice * 1.2;
            }
            else if(UserAge < 25 && _userCarChoice == "Sport")
            {
                UserCarChoicePrice = UserCarChoicePrice * 1.25;
            }
            else if (UserAge < 25 && _userCarChoice == "Minivan")
            {
                UserCarChoicePrice = UserCarChoicePrice * 1.1;
            }
            else if (UserAge >= 25 && _userCarChoice == "Lyx" && UserAge > 60)
            {
                UserCarChoicePrice = UserCarChoicePrice * 1;
            }
            else if (UserAge >= 25 && _userCarChoice == "Sport" && UserAge > 60)
            {
                UserCarChoicePrice = UserCarChoicePrice * 1;
            }
            else if (UserAge >= 25 && _userCarChoice == "Minivan" && UserAge > 60)
            {
                UserCarChoicePrice = UserCarChoicePrice * 1;
            }
            else if (UserAge >= 60 && _userCarChoice == "Lyx")
            {
                UserCarChoicePrice = UserCarChoicePrice * 1.15;
            }
            else if (UserAge >= 60 && _userCarChoice == "Sport")
            {
                UserCarChoicePrice = UserCarChoicePrice * 1.2;
            }
            else if (UserAge >= 60 && _userCarChoice == "Minivan")
            {
                UserCarChoicePrice = UserCarChoicePrice * 1.05;
            }
            return UserCarChoicePrice;
        }
    }
}
