using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Humano:Mamiferos
    {

        public Humano(string nombreHumano) : base(nombreHumano)
        {



        }

        public void pensar()
        {

            Console.WriteLine("Pienso");

        }

    }
}
