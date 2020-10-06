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

        public Output(AgeCalculation ageCal)
        {
            ageCalculator = ageCal;
        }

        public void PrintOutput()
        {
            Console.WriteLine("Now: " + ageCalculator.currentDateTime.Year);
            Console.WriteLine("Input: " + ageCalculator.input.Year);
            Console.WriteLine("Age: " + ageCalculator.age);
        }
    }
}
