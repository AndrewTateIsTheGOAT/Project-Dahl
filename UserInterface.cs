using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl
{
    internal class UserInterface
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Cars UserPreferences()
        {
            PrintCarInfo printCarInfo = new PrintCarInfo();


            Console.WriteLine("Hej, Nu måste du välja 5 st olika bil specifikationer");
            Console.WriteLine("Välj nu en av 3 olika biltyper som vi har i lager(Sport, Lyx, Minivan)");
            string UserCarTypeInput = Console.ReadLine();
            Console.WriteLine("Nu måste du välja mellan Manuell och Automat");
            string UserCarGearInput = Console.ReadLine();
            Console.WriteLine("Nu måste du välja miltal som bilen rullat. DU kan välja mellan 5000 och 10000 mil");
            int UserMilageInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Nu måste du välja mellan Diesel och Bensin");
            string UserFuelInput = Console.ReadLine();
            if ()
            {

            }
            Console.WriteLine("Nu måste du välja pris mellan 1000 och 7500. Siffrans hundratal får bara vara 0 eller 5. Tiotalet och entalet måste vara 0");
            int UserPriceInput = int.Parse(Console.ReadLine());

            if (UserCarTypeInput == "Sport")
            {
                Console.WriteLine("Hur många hästkrafter vill du ha? 200 eller 400 eller 600");
                string Skibidi = Console.ReadLine();
                int inputHorsePower = int.Parse(Skibidi);

                if (inputHorsePower == 200)
                {
                    Cars.Price = printCarInfo.UserCarPrice - 300;
                } 
                else if (inputHorsePower ==400)
                {
                    printCarInfo.UserCarPrice = printCarInfo.UserCarPrice - 0;
                }
                else if(inputHorsePower == 600)
                {
                    printCarInfo.UserCarPrice = printCarInfo.UserCarPrice + 500;
                }
            }
            else if (UserCarTypeInput == "Lyx")
            {
                Console.WriteLine("Vilken komfortnivå vill du ha(1-3)?");
                string inputComfortLevel = Console.ReadLine();
                if(inputComfortLevel == "1")
                {
                    printCarInfo.UserCarPrice = printCarInfo.UserCarPrice - 300;
                }
                else if (inputComfortLevel == "2")
                {
                    printCarInfo.UserCarPrice = printCarInfo.UserCarPrice - 0;
                }
                else if (inputComfortLevel == "¨3")
                {
                    printCarInfo.UserCarPrice = printCarInfo.UserCarPrice + 500;
                }
                else
                {
                    Console.WriteLine("Din input är ogiltigt");
                }
            }
            else if (UserCarTypeInput == "Minivan")
            {
                Console.WriteLine("Vilken dragkrokskapacitet vill du ha?(Mellan 1 - 3)");
                string inputTowbarCapacity = Console.ReadLine();
                if (inputTowbarCapacity == "1")
                {
                    printCarInfo.UserCarPrice = printCarInfo.UserCarPrice - 300;
                }
                else if (inputTowbarCapacity == "2")
                {
                    printCarInfo.UserCarPrice = printCarInfo.UserCarPrice + 0;
                }
                else if (inputTowbarCapacity == "3")
                {
                    printCarInfo.UserCarPrice = printCarInfo.UserCarPrice + 500;
                }
                else
                {
                    Console.WriteLine("ERROR");
                }



            }
            else
            {
                Console.WriteLine("Vi har inte den biltypen");
            }

            Cars cars = new Cars(UserCarTypeInput, UserCarGearInput, UserMilageInput, UserFuelInput, UserPriceInput);

            return cars;
        }
        
    }
}
