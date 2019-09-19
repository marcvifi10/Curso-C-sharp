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

            Console.WriteLine(suma(1,2));
            Console.WriteLine(suma(1,2,3));
            Console.WriteLine(suma(1,2,3,4));

        }

        static int suma(int operador1, int operador2)
        {

            return operador1 + operador2;

        }

        // Sobrecarga de métodos
        static int suma(int n1, int n2, int n3)
        {

            return n1 + n2 + n3;

        }

        static int suma(int n1, int n2, int n3, int n4)
        {

            return n1 + n2 + n3 + n4;

        }
    }
}
