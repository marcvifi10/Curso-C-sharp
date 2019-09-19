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

            Mensaje();
            suma(2,2);

        }

        static void Mensaje()
        {

            Console.WriteLine("Mensaje");

        }

        static void suma(int n1, int n2)
        {

            Console.WriteLine("La suma es: " + (n1+n2));

        }
    }
}
