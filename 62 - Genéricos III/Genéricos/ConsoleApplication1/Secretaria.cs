using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Secretaria:IParaEmpleados
    {

        private double salario;

        public Secretaria(double salario)
        {

            this.salario = salario;

        }

        public double getSalario()
        {

            return salario;

        }

    }
}
