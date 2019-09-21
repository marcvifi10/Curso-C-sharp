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

            Estaciones alegria = Estaciones.Invierno;

            Console.WriteLine(alegria);

            Bonus Antonio = Bonus.bueno;

            double bonusAntonio = (double)Antonio;

            double salarioAntonio = 1500 + bonusAntonio;

            Console.WriteLine(Antonio);

            Console.WriteLine(bonusAntonio);

            Console.WriteLine(salarioAntonio);

            Empleado e1 = new Empleado(Bonus.extra, 1900.50);

            Console.WriteLine("El salario es: " + e1.getSalario());

        }
    }

    enum Estaciones { Primavera, Verano, Otoño, Invierno };

    enum Bonus { bajo=500, normal=1000, bueno=1500, extra=3000 };

}
