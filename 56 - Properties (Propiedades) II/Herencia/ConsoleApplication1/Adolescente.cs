using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Adolescente : Humano
    {
        public Adolescente(string nombreAdolescente) : base(nombreAdolescente)
        {



        }

        public override void pensar()
        {

            Console.WriteLine("Pienso adolescente");

        }

    }
}
