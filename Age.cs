using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Age
    {

        private  int dag;
        public  int Dag
        {
            get {return dag;}
            set { dag = value; }
        }

        private  int maand;
        public int Maand
        {
            get { return maand; }
            set { maand = value; }
        }
        private  int jaar;
        public int Jaar
        {
            get {return jaar;}
            set { jaar = value; }
        }



        public DateTime gebJaar;
        public void omzetten(int Dag, int Maand, int Jaar)
        {
            gebJaar = new DateTime(jaar, maand, dag);
            Console.WriteLine(gebJaar);
        }


    }
}
