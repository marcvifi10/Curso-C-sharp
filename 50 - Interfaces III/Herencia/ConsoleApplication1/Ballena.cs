using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ballena : Mamiferos
    {

        public Ballena(String nombreBallena) : base(nombreBallena)
        {



        }

        public void nadar()
        {

            Console.WriteLine("Nado");

        }

    }
}
