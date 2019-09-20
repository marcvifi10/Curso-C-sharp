using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Gorila : Mamiferos, IMamiferosTerrestres, ISaltar
    {

        public Gorila(string nombreGorila) : base(nombreGorila)
        {



        }

        public void trepar()
        {

            Console.WriteLine("Trepo");
        }

        public int numeroPatas()
        {

            return 4;

        }

        public void saltar()
        {

            Console.WriteLine("Salto");

        }

    }
}
