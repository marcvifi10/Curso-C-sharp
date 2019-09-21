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

            Queue<int> numeros = new Queue<int>();

            // Rellenando o agregando elementos a la cola

            foreach(int numero in new int[5] { 1, 2, 3,4, 5 })
            {

                numeros.Enqueue(numero);

            }

            // recorriendo la cola

            Console.WriteLine("Recorriendo la cola: ");

            foreach(int numero in numeros)
            {

                Console.WriteLine(numero);

            }

            // eliminando elementos de la cola

            Console.WriteLine("\nEliminando elementos: ");

            numeros.Dequeue();

            foreach (int numero in numeros)
            {

                Console.WriteLine(numero);

            }

        }
    }
}