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

            int[] numeros = new int[4];

            numeros[0] = 7;
            numeros[1] = 8;
            numeros[2] = 9;
            numeros[3] = 10;

            ProcesaDatos(numeros);

            foreach(int i in numeros)
            {

                Console.WriteLine(i);

            }

            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el Main");

            foreach(int i in arrayElementos)
            {

                Console.WriteLine(i);

            }

        }

        static void ProcesaDatos(int[] datos)
        {

            foreach(int i in datos)
            {

                Console.WriteLine(i+10);

            }

        }

        static int[] LeerDatos()
        {

            Console.WriteLine("¿Cuantos elementos quieres que tenga el array?");

            string respuesta = Console.ReadLine();

            int numElementos = Convert.ToInt32(respuesta);

            int[] datos = new int[numElementos];

            for(int i = 0; i < numElementos; i++)
            {

                Console.WriteLine("Introduce el dato para la posición [" + i + "]");

                respuesta = Console.ReadLine();

                int datosElemento = Convert.ToInt32(respuesta);

                datos[i] = datosElemento;

            }

            return datos;

        }
    }
}
