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

            Stack<int> numeros = new Stack<int>();

            // Rellenando o agregando elementos a la pila

            foreach(int numero in new int[5] { 1, 2, 3,4, 5 })
            {

                numeros.Push(numero);

            }

            // recorriendo la pila

            Console.WriteLine("Recorriendo la pila: ");

            foreach(int numero in numeros)
            {

                Console.WriteLine(numero);

            }

            // eliminando elementos de la pila

            Console.WriteLine("\nEliminando elementos: ");

            numeros.Pop();

            foreach (int numero in numeros)
            {

                Console.WriteLine(numero);

            }

            // ---------- DICTIONARY --------------------------------------

            Dictionary<string, int> edades = new Dictionary<string, int>();

            // Rellenando el diccionario

            edades.Add("Marc", 22);
            edades.Add("Alex", 19);

            edades["María"] = 25;
            edades["Antonio"] = 29;

            // Recorrer el diccionario

            Console.WriteLine();

            foreach(KeyValuePair<string, int> persona in edades)
            {

                Console.WriteLine("Nombre: " + persona.Key + "\nEdad: " + persona.Value + "\n");
                
            }

        }
    }
}