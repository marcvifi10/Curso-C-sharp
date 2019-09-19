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

            Coche c1 = new Coche();

            Console.WriteLine(c1.Ruedas);

            c1.Ruedas = 5;

            Console.WriteLine(c1.Ruedas);

            Coche c2 = new Coche(6,15.15,5.5,true,"Cuero");

            Console.WriteLine(c2.Ruedas);

            c2.Ruedas = 5;

            Console.WriteLine(c2.Ruedas);

        }
    }
}
