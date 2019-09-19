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

            Random numero = new Random();

            int aleatorio = numero.Next(0,100);

            int minumero = 101;

            int intentos = 0;

            Console.WriteLine("Entra un numero entre 0 y 100: ");

            while(aleatorio != minumero)
            {

                intentos++;

                minumero = Convert.ToInt32(Console.ReadLine());

                if(minumero > aleatorio)
                {

                    Console.WriteLine("Menor");

                }
                else if (minumero < aleatorio)
                {

                    Console.WriteLine("Mayor");

                }
                else
                {

                    Console.WriteLine("Felicidades!!!, has necesitado " + intentos + " intentos.");

                }

            }

        }
    }
}
