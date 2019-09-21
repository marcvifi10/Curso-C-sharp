using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Lagartija : Animales
    {

        private String nombreReptil;

        public Lagartija(String nombre)
        {

            nombreReptil = nombre;

        }

        public override void getNombre()
        {

            Console.WriteLine("El nombre del reptil es: " + nombreReptil);

        }
    }
}
