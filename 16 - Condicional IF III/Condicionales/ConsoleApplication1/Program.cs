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

            string carnet = "no";

            Console.WriteLine("Entra tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if(edad >= 18)
            {

                Console.WriteLine("¿Tienes carnet?");

                carnet = Console.ReadLine();

            }
            if(edad >= 18 && carnet == "si" || carnet == "Si" || carnet == "SI")
            {

                Console.WriteLine("Puedes conducir!!!");

            }
            else
            {

                Console.WriteLine("NO puedes conducir!!!");

            }

        }
    }
}
