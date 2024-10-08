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
        public string UserPreferences()
        {
            Console.WriteLine("Hej, Nu måste du välja 5 st olika bil specifikationer");
            Console.WriteLine("Välj nu en av 3 olika biltyper som vi har i lager(Sport, Lyx, Minivan)");
            string UserCarTypeInput = Console.ReadLine();
            Console.WriteLine("Nu måste du välja mellan Manuell och Automat");
            string UserCarGearInput = Console.ReadLine();
            Console.WriteLine("Nu måste du välja miltal som bilen rullat. DU kan välja mellan 5000, 10000 och 15000 mil");
            int UserMilageInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Nu måste du välja mellan Diesel och Bensin");
            string UserFuelInput = Console.ReadLine();
            Console.WriteLine("Nu måste du välja pris mellan 1000 och 7500. Siffrans hundratal får bara vara 0 eller 5. Tiotalet och entalet måste vara 0");
            int UserPriceInput = int.Parse(Console.ReadLine());


            Cars cars = new Cars(UserCarTypeInput, UserCarGearInput, UserMilageInput, UserFuelInput, UserPriceInput);
            return "Koden kan inte hanteras";
        }
        
    }
}
