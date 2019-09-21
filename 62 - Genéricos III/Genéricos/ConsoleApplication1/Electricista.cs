using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Electricista:IParaEmpleados
    {

        private double salario;

        public Electricista(double salario)
        {

            this.salario = salario;

        }

        public double getSalario()
        {

            return salario;

        }

    }
}
