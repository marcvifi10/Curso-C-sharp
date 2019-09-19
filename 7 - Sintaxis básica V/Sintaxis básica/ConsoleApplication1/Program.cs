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

            int num1, num2, suma;

            Console.WriteLine("Entra un número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entra otro número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;

            Console.WriteLine("La suma es: " + suma);

        }
    }
}
