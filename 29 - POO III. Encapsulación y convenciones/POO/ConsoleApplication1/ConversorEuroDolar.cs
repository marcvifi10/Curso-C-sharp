using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ConversorEuroDolar
    {

        private double euro = 1.253;

        public double convierte(double cantidad)
        {

            return cantidad * euro;

        }

    }
}
