using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class AgeCalculation
    {
        private DateTime _currentDateTime;

        public AgeCalculation()
        {
            _currentDateTime = DateTime.Today;
        }

        public int CalculateAge(DateTime input)
        {
            int age = _currentDateTime.Year - input.Year;
            Console.WriteLine("Now: " + _currentDateTime.Year);
            Console.WriteLine("Input: " + input.Year);
            Console.WriteLine("Age: " + age);
            return age;
        }


    }
}
