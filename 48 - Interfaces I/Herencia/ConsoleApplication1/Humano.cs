using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Humano:Mamiferos,IMamiferosTerrestres
    {

        public Humano(string nombreHumano) : base(nombreHumano)
        {



        }

        public override void pensar()
        {

            Console.WriteLine("Pienso");

        }

        public int numeroPatas()
        {

            return 2;

        }

    }
}
