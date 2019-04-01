using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brumbrum
{
    class Auto
    {
        int geschwindigkeit;
        int maxGeschwindigkeit;
        string marke;


        public int getGeschwindigkeit()
        {
            return geschwindigkeit;
        }

        public bool setGeschwindigkeit(int inputGeschwindigkeit)
        {
            if (inputGeschwindigkeit <= 250)
            {
                geschwindigkeit = inputGeschwindigkeit;
                return true;
            }
            else
                return false;
        }




    }
}
