using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brumbrum
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a = new Auto();
            bool z = a.setGeschwindigkeit(210);
            Console.WriteLine(z + ", " + a.getGeschwindigkeit());


            Console.ReadLine();
        }
    }
}
