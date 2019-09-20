using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Mamiferos
    {

        private String nombreSerVivo;

        public Mamiferos(String nombre)
        {

            nombreSerVivo = nombre;

        }

        public void respirar()
        {

            Console.WriteLine("Respiro");

        }

        public virtual void pensar()
        {

            Console.WriteLine("Pensamiento instintivo!!!");

        }

        public void cuidarCrias()
        {

            Console.WriteLine("Cuido de mis crías");

        }

        public void getNombre()
        {

            Console.WriteLine(nombreSerVivo);

        }

    }

}
