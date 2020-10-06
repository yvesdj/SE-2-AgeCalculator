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
            Age leeftijd = new Age();
            leeftijd.InputCall();
            Console.WriteLine("\nDe geboorte datum is " + leeftijd.Dag + "/" + leeftijd.Maand + "/" + leeftijd.Jaar + ".\n");

            AgeCalculation calculator = new AgeCalculation();
            calculator.CalculateAge(leeftijd.Omzetten());

            Output output = new Output(calculator);
            output.PrintOutput();

            Console.ReadLine();
        }
        

        
    }
}
