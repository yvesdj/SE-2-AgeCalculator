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
        public DateTime Omzetten()
        {
            gebJaar = new DateTime(jaar, maand, dag);
            //Console.WriteLine(gebJaar);
            return gebJaar;
        }


        public void InputCall()
        {
            Console.WriteLine("Geef dag");
            int dagInt = Convert.ToInt32(Console.ReadLine());
            Dag = dagInt;
           

            Console.WriteLine("Geef maand");
            int maandInt = Convert.ToInt32(Console.ReadLine());
            Maand = maandInt;
            

            Console.WriteLine("Geef jaar");
            int jaarInt = Convert.ToInt32(Console.ReadLine());
            Jaar = jaarInt;

            Omzetten(dagInt, maandInt, jaarInt);
           
            
        }

    }
}
