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

            // Declarar una lista
            List<int> numeros = new List<int>();
            int[] listaNumeros = new int[] {3,6,8};
            List<int> numeros2 = new List<int>();

            numeros.Add(5);
            numeros.Add(4);
            numeros.Add(3);

            for (int i = 0; i < numeros.Count; i++)
            {

                numeros.Add(listaNumeros[i]);

            }

            for (int i = 0; i < numeros.Count; i++)
            {

                Console.WriteLine(numeros[i]);

            }

            Console.WriteLine("Elementos de la lista: ");
            int elem = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < elem; i++)
            {

                numeros2.Add(Convert.ToInt32(Console.ReadLine())); ;

            }

            for (int i = 0; i < numeros2.Count; i++)
            {

                Console.WriteLine(numeros2[i]);

            }

        }
    }
}