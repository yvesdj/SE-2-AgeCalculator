using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    public class AgeCalculation
    {
        public DateTime currentDateTime;
        public DateTime input;

        public int age;

        public AgeCalculation()
        {
            currentDateTime = DateTime.Today;
        }

        public int CalculateAge(DateTime input)
        {
            this.input = input;
            age = currentDateTime.Year - input.Year;


            return age;
        }


    }
}
