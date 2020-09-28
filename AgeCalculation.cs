using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class AgeCalculation
    {
        public DateTime Input { get; set; }
        private DateTime _currentDateTime;

        public AgeCalculation(DateTime input)
        {
            Input = input;
            _currentDateTime = new DateTime();
        }

        public TimeSpan CalculateAge()
        {
            _currentDateTime = DateTime.Now;
            TimeSpan output = _currentDateTime - Input;
            Console.WriteLine("{0} - {1} = {2}", _currentDateTime, Input, output.ToString());
            return output;
        }


    }
}
