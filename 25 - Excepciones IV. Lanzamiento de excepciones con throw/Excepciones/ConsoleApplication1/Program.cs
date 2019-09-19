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

            Console.WriteLine("Entra un nº de mes: ");

            int n_Mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(NombreDelMes(n_Mes));

        }

        public static string NombreDelMes(int mes)
        {

            switch(mes)
            {

                case 1:

                    return "Enero";

                case 2:

                    return "Febrero";

                case 3:

                    return "Marzo";

                case 4:

                    return "Abril";

                case 5:

                    return "Mayo";

                case 6:

                    return "Junio";

                case 7:

                    return "Julio";

                case 8:

                    return "Agosto";

                case 9:

                    return "Setiembre";

                case 10:

                    return "Octubre";

                case 11:

                    return "Noviembre";

                case 12:

                    return "Diciembre";

                default:

                    throw new ArgumentOutOfRangeException();

            }

        }
    }
}
