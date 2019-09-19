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

            int edad;

            Console.WriteLine("Entra una edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if(edad < 18)
            {

                Console.WriteLine("Eres un niño");

            }
            else if (edad < 30)
            {

                Console.WriteLine("Eres joven");

            }
            else if (edad < 60)
            {

                Console.WriteLine("Eres maduro");

            }
            else
            {

                Console.WriteLine("Eres viejo");

            }

        }
    }
}
