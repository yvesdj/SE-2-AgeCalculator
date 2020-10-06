using System;
using System.Collections.Generic;
using System.Threading;
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
            VerderGaan();
        }

        public string naam;
        public string NaamCall()
        {
            Console.WriteLine("Vul hier uw naam in aub..");
            naam = Console.ReadLine();
            return naam;
            
        }

        public void VerderGaan()
        {
            Console.WriteLine("Als u wenst verder te gaan, typ dan 'Ja', indien u wilt stoppen en afsluiten, type dan 'nee', Geen hoofdletters.");
            string antwoord = Console.ReadLine();

            if(antwoord == "ja")
            {
                Console.WriteLine("oke");
            }
            else
            {
                Console.WriteLine("Programma word afgesloten binnen 3 sec.");
                Console.Write("3...");
                Thread.Sleep(1000);
                Console.Write("2...");
                Thread.Sleep(1000);
                Console.Write("1...");
                Thread.Sleep(1000);
                System.Environment.Exit(0);
            }

        }


    }
}
