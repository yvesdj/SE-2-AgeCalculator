using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        }

        public void PrintOutput()
        {
            Console.WriteLine("Now: " + ageCalculator.currentDateTime.Year);
            Console.WriteLine("Input: " + ageCalculator.input.Year);
            Console.WriteLine("Age: " + ageCalculator.age);

            Console.WriteLine("\nYou will die on the following date: " + deathCalculator.RandomDate.ToString("dddd, dd MMMM yyyy"));
        }
    }
}
