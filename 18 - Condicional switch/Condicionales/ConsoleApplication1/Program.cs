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

            char op;
            int n1, n2, resul;

            Console.WriteLine("Entra un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entra otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entra un operador: ");
            op = Convert.ToChar(Console.ReadLine());

            switch(op)
            {

                case '+':

                    resul = n1 + n2;

                    Console.WriteLine("El resultado es: " + resul);

                break;

                case '-':

                    resul = n1 - n2;

                    Console.WriteLine("El resultado es: " + resul);

                break;

                case '*':

                    resul = n1 * n2;

                    Console.WriteLine("El resultado es: " + resul);

                break;

                case '/':

                    resul = n1 + n2;

                    Console.WriteLine("El resultado es: " + resul);

                break;

                default:

                    Console.WriteLine("ERROR!!!");

                break;


            }

        }
    }
}
