using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreisUebung
{
    class Kreis
    {
        //Member
        private double mDurchmesser;


        //Konstrutoren

        public Kreis()
        {
            setDurchmesser(1);
        }

        public Kreis(double d)
        {
            setDurchmesser(d);
        }

        //Methoden
        public double getDurchmesser()
        {
            return mDurchmesser;
        }

        public void setDurchmesser(double d)
        {
            if(d > 0)
            {
                mDurchmesser = d;
            }
            else
            {
                Console.WriteLine("Durchmesser muss grösser als 0 sein");
            }

        }

        public double getUmfang()
        {
            return mDurchmesser * Math.PI;
        }

        public double getFlaeche()
        {
            return Math.Pow(mDurchmesser, 2)*Math.PI/4;
        }
    }


}
