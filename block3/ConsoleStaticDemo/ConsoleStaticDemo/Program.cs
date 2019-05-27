using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            House h1 = new House(3);
            Console.WriteLine(House.houseCounter + " " + h1.windows);
            House h2 = new House(10);
            Console.WriteLine(House.houseCounter + " " + h2.windows);
            House h3 = new House(67);
            Console.WriteLine(House.houseCounter + " " + h3.windows);
            Console.ReadKey();
        }
    }
}
