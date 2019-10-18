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

            Personas p1 = new Personas();
            p1.Nombre = "Juan";
            p1.Edad = 22;

            Personas p2 = new Personas();
            p2.Nombre = "Maria";
            p2.Edad = 28;

            ComparaPersonas1 comparaEdad = (persona1, persona2) => persona1 == persona2;
            ComparaPersonas2 comparaNombre = (persona1, persona2) => persona1 == persona2;

            Console.WriteLine(comparaEdad(p1.Edad, p2.Edad));
            Console.WriteLine(comparaNombre(p1.Nombre, p2.Nombre));
            Console.WriteLine();

            // Uso del delegado

            OperacionesMatematicas1 operacion1 = new OperacionesMatematicas1(num => num * num);
            OperacionesMatematicas2 operacion2 = new OperacionesMatematicas2((num1, num2) => num1 + num2);

            Console.WriteLine(operacion1(4));
            Console.WriteLine(operacion2(4,4));
            Console.WriteLine();

            // Operacion 2

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);

            Console.WriteLine("NÚMEROS PARES:");

            /*foreach (int numero in numerosPares)
            {

                Console.WriteLine(numero);

            }*/

            numerosPares.ForEach(numero => Console.WriteLine(numero));

            Console.WriteLine();
            numerosPares.ForEach(numero => 
                                {
                                    Console.WriteLine("El número par es: ");
                                    Console.WriteLine(numero);
                                });

        }

        public delegate int OperacionesMatematicas1(int numero);

        public delegate int OperacionesMatematicas2(int numero1, int numero2);

        public delegate bool ComparaPersonas1(int edad1, int edad2);

        public delegate bool ComparaPersonas2(String nombre1, String nombre2);

        /*public static int Cuadrado(int num)
        {

            return num * num;

        }*/

        /*public static int Suma(int n1, int n2)
        {

            return n1 + n2;
        
        }*/

    }
}
