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
            Console.WriteLine("Geef dag");
            int dagInt = Convert.ToInt32(Console.ReadLine());
            leeftijd.Dag = dagInt;

            Console.WriteLine("Geef maand");
            int maandInt = Convert.ToInt32(Console.ReadLine());
            leeftijd.Maand = maandInt;

            Console.WriteLine("Geef jaar");
            int jaarInt = Convert.ToInt32(Console.ReadLine());
            leeftijd.Jaar = jaarInt;

            Console.WriteLine("De geboorte datum is " + leeftijd.Dag + "/" + leeftijd.Maand + "/" + leeftijd.Jaar + ".");
            leeftijd.omzetten(dagInt, maandInt, jaarInt);
            Console.ReadLine();
        }
        

        
    }
}
