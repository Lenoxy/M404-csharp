using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreisUebung
{
    class Program
    {
        static void Main(string[] args)
        {
            Kreis a = new Kreis();
            Console.WriteLine("Geben Sie den Durchmesser Ihres Kreises ein:");
            a.setDurchmesser(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Fläche: " + Convert.ToString(a.getFlaeche()));
            Console.WriteLine("Umfang: " + Convert.ToString(a.getUmfang()));
            Console.ReadKey();
        }
    }
}
