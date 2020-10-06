using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Welkom
    {
        public void WelkomScherm()
        {
            Console.WriteLine("< ----------------------- Leeftijd Calculator ----------------------- >");
            Console.WriteLine("");
            Console.WriteLine("");
            NaamCall();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Welkom " + naam + " bij onze leeftijd calculator!");
            Console.WriteLine("Geef uw geboortedatum in en wij berekenen uw leeftijd.");
            Console.WriteLine("");
            Console.WriteLine("Druk op een toets om verder te gaan..");
            Console.ReadLine();
        }

        public string naam;
        public string NaamCall()
        {
            Console.WriteLine("Vul hier uw naam in aub..");
            naam = Console.ReadLine();
            return naam;
        }
    }
}
