using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AgeCalculator
{
    public class Output
    {
        public AgeCalculation ageCalculator;
        public DeathCalculator deathCalculator;

        public Output(AgeCalculation ageCal)
        {
            ageCalculator = ageCal;
        }

        public Output(AgeCalculation ageCal, DeathCalculator deathCal)
        {
            ageCalculator = ageCal;
            deathCalculator = deathCal;
        }

        public void CloseOrRestart()
        {
            Console.WriteLine("\nDo you want to calculate again?");
            Console.WriteLine("Type 'yes' to restart or 'no' to close the application.");
            string answ = Console.ReadLine();

            switch (answ)
            {
                case "yes":
                    Console.WriteLine("The application will restart momentarily.");
                    Thread.Sleep(1000);
                    StateManager.Instance.Run();
                    break;

                case "no":
                    Console.WriteLine("The application will close momentarily");
                    Thread.Sleep(1000);
                    StateManager.Instance.Exit();
                    break;
                default:
                    break;
            }
        }

        public void PrintOutput()
        {
            Console.WriteLine("Now: " + ageCalculator.currentDateTime.Year);
            Console.WriteLine("Input: " + ageCalculator.input.Year);
            Console.WriteLine("Age: " + ageCalculator.age);

            Console.WriteLine("\nYou will die on the following date: " + deathCalculator.RandomDate.ToString("dddd, dd MMMM yyyy"));

            CloseOrRestart();
        }
    }
}
