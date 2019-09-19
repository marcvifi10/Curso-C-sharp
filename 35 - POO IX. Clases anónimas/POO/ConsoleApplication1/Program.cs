using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Math;
using static System.Console;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            // realizarTarea();

            double raiz = Sqrt(9);

            double potencia = Pow(3,4);

            WriteLine(raiz);

            WriteLine(potencia);

            var miVariable = new { Nombre="Marc",Edad=22 };

            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);

            var miOtraVariable = new { Nombre = "Alex", Edad = 19 };

            miVariable = miOtraVariable;

        }

        static void realizarTarea()
        {

            Punto origen = new Punto(2,3);

            Punto destino = new Punto();

            double distancia = origen.DistanciaHasta(destino);

            WriteLine("La distancia es: " + distancia);

            WriteLine("Número de objetos: " + Punto.ContadorDeObjetos());

        }

    }
}
