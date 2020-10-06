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

            Console.WriteLine("De geboorte datum is " + leeftijd.Dag + "/" + leeftijd.Maand + "/" + leeftijd.Jaar + ".");
           
            Console.ReadLine();
        }
        

        
    }
}
