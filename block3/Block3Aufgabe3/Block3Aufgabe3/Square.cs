using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3Aufgabe3
{
    class Square
    {
        private double width;
        private double length;

        public double umfang;
        public double flaeche;

        public Square(double nWidth, double nLength)
        {
            setLength(nLength);
            setWidth(nWidth);
            calculate();
        }

        public void setWidth(double nWidth)
        {
            if(nWidth < 500 && nWidth > 1)
            {
                width = nWidth;
            }
        }

        public void setLength(double nLength)
        {
            if (nLength < 500 && nLength > 1)
            {
                length = nLength;
            }
        }



        public void calculate()
        {
            umfang = (2 * length) + (2 * width);
            flaeche = length * width;
        }
    }
}
