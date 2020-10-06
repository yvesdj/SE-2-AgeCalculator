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
            Console.WriteLine("");
            Console.WriteLine("Als u wenst verder te gaan, typ dan 'ja', indien u wilt stoppen en afsluiten, type dan 'nee', Geen hoofdletters.");
            string antwoord = Console.ReadLine();

            if(antwoord == "ja")
            {
                Console.WriteLine("");
                Console.WriteLine("U koos om verder te gaan met onze calculator! Beantwoord nu de volgende vragen.");
                Console.WriteLine("");
            }
            else if (antwoord == "nee")
            {
                Console.WriteLine("");
                Console.WriteLine("Programma word afgesloten binnen 3 sec.");
                Console.Write("3...");
                Thread.Sleep(1000);
                Console.Write("2...");
                Thread.Sleep(1000);
                Console.Write("1...");
                Thread.Sleep(1000);
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Dat was geen juist antwoord, vul alstublieft 'ja' of 'nee' in.");
                VerderGaan();
            }

        }


    }
}
