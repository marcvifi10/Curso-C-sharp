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

            Circulo miCirculo = new Circulo();

            Console.WriteLine("El área es: " + miCirculo.calculoArea(5));

            ConversorEuroDolar obj = new ConversorEuroDolar();

            Console.WriteLine(obj.convierte(50));

        }
    }
}
