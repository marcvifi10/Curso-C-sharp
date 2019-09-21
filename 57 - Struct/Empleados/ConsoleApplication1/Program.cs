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

            Empleado e1 = new Empleado(1200, 250);

            e1.cambiaSalario(e1, 200);

            Console.WriteLine(e1);

        }
    }
}
