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

            c1.getNombre();
            h1.getNombre();
            g1.getNombre();
            g1.trepar();

        }
    }
}
