using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AgeCalculation ageCalculation = new AgeCalculation(new DateTime(2012, 01, 01));
            ageCalculation.CalculateAge();

            Console.ReadLine();
        }
    }
}
