using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesDeportes, ISaltar
    {

        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

            

        }

        public bool esOlimpico()
        {

            return true;

        }

        public void galopear()
        {

            Console.WriteLine("Galopo");

        }

        public int numeroPatas()
        {

            return 4;

        }

        public string tipoDeporte()
        {

            return "Hípica";

        }

        public void saltar()
        {

            Console.WriteLine("Salto");

        }
    }
}
