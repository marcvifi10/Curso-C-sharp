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

            var datos = new[] {"Marc","Villalobos","España"};

            Empleados[] arrayEmpleados = new Empleados[2];

            arrayEmpleados[0] = new Empleados("Marc",22);

            Empleados Ana = new Empleados("Ana",30);

            arrayEmpleados[1] = Ana;

            var personas = new[]
            {

                new {Nombre="Juan",Edad=19},
                new {Nombre="Maria",Edad=39},
                new {Nombre="Diana",Edad=35}

            };

            Console.WriteLine(personas[2]);

        }
    }
}
