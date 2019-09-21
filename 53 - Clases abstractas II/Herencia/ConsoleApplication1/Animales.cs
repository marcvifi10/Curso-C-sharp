using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Animales
    {

        public void respirar()
        {

            Console.WriteLine("Respiro");

        }

        public abstract void getNombre();

    }
}
