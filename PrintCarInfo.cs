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
        private CheckForFittingCars Fitting = new CheckForFittingCars();

        private string AskUserForCarChoice()
        {
            if ()
            {
                Console.WriteLine("Vilken DragkroksKapacitet vill du ha?");
                string UserAnswer = Console.ReadLine();


            }
            else if ()
            {
                Console.WriteLine("Hur många hästkrafter vill du ha?");
                string UserAnswer = Console.ReadLine();
            }
            else if ()
            {
                Console.WriteLine("¨Vilken komfort nivå vill du hà?");
                string UserAnswer = Console.ReadLine();
            }


            Console.WriteLine("Choose one of these cars: ");
            for (int i = 0; i < Fitting.CarList.Count; i++)
            {
                Console.WriteLine(Fitting.CarsThatFit("Sport", "Manual", 10000, "Diesel"));
            }




            return "ERROR";
        public string CarChoice
        {
            get { return _userCarChoice; }
            set { _userCarChoice = value; }
        }
    }
}
