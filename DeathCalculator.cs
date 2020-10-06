using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    public class DeathCalculator
    {
        public Random Random => new Random();

        public DateTime RandomDate { get; set; }

        public DeathCalculator()
        {
            DateTime endRange = new DateTime(2100, 1, 1);
            int range = 60 * 365;
            RandomDate = DateTime.Today.AddDays(Random.Next(range));
        }

    }
}
