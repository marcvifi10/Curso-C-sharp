using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Mamiferos:Animales
    {

        private String nombreSerVivo;

        public Mamiferos(String nombre)
        {

            nombreSerVivo = nombre;

        }

        public virtual void pensar()
        {

            Console.WriteLine("Pensamiento instintivo!!!");

        }

        public void cuidarCrias()
        {

            Console.WriteLine("Cuido de mis crías");

        }

        public override void getNombre()
        {

            Console.WriteLine("El nombre del mamífero es: " + nombreSerVivo);

        }

    }

}
