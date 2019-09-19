using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int v1 = 7;
            double v2 = 5.2;
            double v3 = 8.3;

            Console.WriteLine(Suma(v1, v2));

        }

        public static double Suma(int n1, double n2, double n3 = 0)
        {

            return n1 + n2 + n3;

        }

        public static double Suma(int n1, double n2)
        {

            return n1 + n2;

        }

    }
}
