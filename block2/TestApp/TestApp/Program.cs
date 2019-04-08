using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        enum mode
        {
            Off = 0,
            Working = 1,
            Error = 2,
        }

        static void Main(string[] args)
        {
            mode mode = mode.Off;

            try
            {
                Console.WriteLine(Math.Sqrt(2));
                mode = mode.Working;

            }
            catch
            {
                mode = mode.Error;
            }

            car a = new car();

            a.speed = 90;
            a.length = "a";


            Console.WriteLine(mode);


            int[] arr = new int[5000];





            Console.ReadKey();
        }

        public struct car
        {

            public double speed;
            public string length;
            public string type;

        }
    


    }
}
