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

            Console.WriteLine("Entra tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tu edad es: " + edad);

        }
    }
}
