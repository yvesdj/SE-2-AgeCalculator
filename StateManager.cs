using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    public sealed class StateManager
    {
        private static readonly StateManager instance = new StateManager();

        public static StateManager Instance => instance;

        static StateManager() { }

        private StateManager() { }

        public void Run()
        {
            Console.Clear();
            Welkom startscherm = new Welkom();
            startscherm.WelkomScherm();
            Age leeftijd = new Age();
            leeftijd.InputCall();
            Console.WriteLine("\nDe geboorte datum is " + leeftijd.Dag + "/" + leeftijd.Maand + "/" + leeftijd.Jaar + ".\n");

            AgeCalculation calculator = new AgeCalculation();
            calculator.CalculateAge(leeftijd.Omzetten());

            DeathCalculator deathCalculator = new DeathCalculator();

            //Output output = new Output(calculator);
            Output output = new Output(calculator, deathCalculator);
            output.PrintOutput();

            Console.ReadLine();
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
