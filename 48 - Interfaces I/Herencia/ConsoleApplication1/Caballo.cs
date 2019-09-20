using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Caballo : Mamiferos, IMamiferosTerrestres
    {

        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

            

        }

        public void galopear()
        {

            Console.WriteLine("Galopo");

        }

        public int numeroPatas()
        {

            return 4;

        }
    }
}
