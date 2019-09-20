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

            Console.WriteLine("Probando el avión");

            Avion a1 = new Avion();

            a1.ArrancarMotor("rrrrrrrrr");

            a1.Despegar();

            a1.Aterrizar();

            a1.PararMotor("sssssssssss");

            Console.WriteLine();

            Console.WriteLine("Probando el coche");

            Coche c1 = new Coche();

            c1.ArrancarMotor("rum");

            c1.Acelerar();

            c1.Conducir();

            c1.Frenar();

            c1.PararMotor("ssssss");

            Console.WriteLine();

            Console.WriteLine("Poliformismo");

            Vehiculo v1 = c1;

            v1.Conducir();

            v1 = a1;

            v1.Conducir();

        }
    }
}
