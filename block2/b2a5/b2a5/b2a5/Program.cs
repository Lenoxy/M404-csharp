using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2a5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<byte> eingabeL = new List<byte>();
            byte eingabe;
            bool failed = false;
            for(int i = 0; i < 5; i++)
            {
                try
                {
                    if (failed)
                    {
                        i--;
                    }
                    Console.Write("Zahl " + Convert.ToString(i + 1) + ": ");
                    eingabe = Convert.ToByte(Console.ReadLine());
                    eingabeL.Add(Convert.ToByte(eingabe));
                    failed = false;
                }
                catch
                {
                    Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 256 ein.");
                    failed = true;
                }
            }

        }
    }
}
