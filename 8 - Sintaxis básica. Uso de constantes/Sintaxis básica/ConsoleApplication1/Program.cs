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

            const int x = 4;
            const int y = 8;
            const double PI = 3.14159;
            double radio = 3.15;

            Console.WriteLine("El valor de x es: " + x);

            double area = Math.Pow(radio,2) * PI;
            Console.WriteLine("El area es: " + area);

        }
    }
}
