using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Caballo c1 = new Caballo("Babieca");
            Humano h1 = new Humano("Marc");
            Gorila g1 = new Gorila("Copito");

            Mamiferos animal = new Caballo("Bucéfalo");
            Mamiferos persona = new Humano("Marc");

            Object miAnimal = new Caballo("Caballo");
            Object miMamiferos = new Mamiferos("Mamífero1");

            Mamiferos[] almacenAnimales = new Mamiferos[3];
            almacenAnimales[0] = c1;
            almacenAnimales[1] = h1;
            almacenAnimales[2] = g1;

            almacenAnimales[1].getNombre();

            for(int i = 0; i < almacenAnimales.Length; i++)
            {

                almacenAnimales[i].pensar();

            }

            Console.WriteLine("Número de patas: " + h1.numeroPatas());

            Lagartija l1 = new Lagartija("Juancho");

            l1.getNombre();

            l1.respirar();

            h1.respirar();

            /*c1.getNombre();
            h1.getNombre();
            g1.getNombre();
            g1.trepar();*/

        }
    }
}
