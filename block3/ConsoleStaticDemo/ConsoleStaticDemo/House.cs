using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStaticDemo
{
    class House
    {
        //Obviously, variables sHoULd nEvER Be puBLic
        public static int houseCounter = 0;
        public int windows;

        public House(int userWindows)
        {
            this.windows = userWindows;
            houseCounter++;
        }

    }
}
