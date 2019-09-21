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

            AlmacenObjetos<Empleado> archivos = new AlmacenObjetos<Empleado>(10);

            /*archivos.agregar("Marc");
            archivos.agregar("Juan");
            archivos.agregar("Alex");
            archivos.agregar("Sandra");*/

            archivos.agregar(new Empleado(1500));

            Empleado salario = archivos.getElemento(4);

            Console.WriteLine(salario.getSalario());

        }
    }
}
