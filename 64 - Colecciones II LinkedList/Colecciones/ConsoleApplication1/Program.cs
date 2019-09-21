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

            LinkedList<int> numeros = new LinkedList<int>(); 

            foreach(int numero in new int[] { 10, 8, 7, 6, 4 })
            {

                numeros.AddFirst(numero);

            }

            numeros.Remove(6);

            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);

            numeros.AddFirst(nodoImportante);

            foreach (int numero in numeros)
            {

                Console.WriteLine(numero);

            }

            for(LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
            {

                int numero = nodo.Value;

                Console.WriteLine(numero);

            }

        }
    }
}