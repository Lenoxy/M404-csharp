using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3_Aufgabe7
{
    class Kreis
    {
        public double durchmesser;
        public double flaeche;
        public Kreis(double d)
        {
            durchmesser = d;
            flaeche = (Math.PI * Math.Pow(d, 2)) / 4;
        }

    }
}
