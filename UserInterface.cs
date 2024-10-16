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
        /// Den ska fråga användaren alla viktiga bil-specifikation-fråger och spara dem värdena  i olika objekt. Dessutom ska den kolla vilken biltyp som användaren valt och basera en fråga på användarens input. 
        /// </summary>
        /// <returns></returns>
        public CarUserPreferences UserPreferences()
        {
            PrintCarInfo printCarInfo = new PrintCarInfo();

            
            Console.WriteLine("Hej, Nu måste du välja 5 st olika bil specifikationer");
            Console.WriteLine("Välj nu en av 3 olika biltyper som vi har i lager(Sport, Lyx, Minivan)");
            string UserCarTypeInput = Console.ReadLine();
            Console.WriteLine("==============================================");
            Console.WriteLine("Nu måste du välja mellan Manuell och Automat");
            string UserCarGearInput = Console.ReadLine();
            Console.WriteLine("==============================================");
            Console.WriteLine("Nu måste du välja miltal som bilen rullat. DU kan välja mellan 5000 och 10000 mil");
            int UserMilageInput = int.Parse(Console.ReadLine());
            Console.WriteLine("==============================================");
            Console.WriteLine("Nu måste du välja mellan Diesel och Bensin");
            string UserFuelInput = Console.ReadLine();
            Console.WriteLine("==============================================");
            Console.WriteLine("Nu måste du välja pris mellan 1000 och 7500. Siffrans hundratal får bara vara 0 eller 5. Tiotalet och entalet måste vara 0");
            int UserPriceInput = int.Parse(Console.ReadLine());
            Console.WriteLine("==============================================");

            int SpecificCarSpecification;

            if (UserCarTypeInput == "Sport")
            {
                Console.WriteLine("Hur många hästkrafter vill du ha? 200 eller 400 eller 600");
                string SkibidiHorsePower = Console.ReadLine();
                SpecificCarSpecification = int.Parse(SkibidiHorsePower);
            }
            else if (UserCarTypeInput == "Lyx")
            {
                Console.WriteLine("Vilken komfortnivå vill du ha(1-3)?");
                string inputComfortLevel = Console.ReadLine();
                SpecificCarSpecification = int.Parse(inputComfortLevel);
            }
            else if (UserCarTypeInput == "Minivan")
            { 
                Console.WriteLine("Vilken dragkrokskapacitet vill du ha?(Mellan 1 - 3)");
                string inputTowbarCapacity = Console.ReadLine();
                SpecificCarSpecification = int.Parse(inputTowbarCapacity);
            }
            else
            {
                SpecificCarSpecification = 1;
            }

            CarUserPreferences cars = new CarUserPreferences(SpecificCarSpecification, UserCarTypeInput, UserCarGearInput, UserFuelInput, UserMilageInput, UserPriceInput);

            return cars;
        }
        
    }
}
