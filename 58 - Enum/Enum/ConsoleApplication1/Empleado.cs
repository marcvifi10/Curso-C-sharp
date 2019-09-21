using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Empleado
    {

        private double salario;
        private Bonus bonusEmpleado;

        public Empleado(Bonus bonusEmpleado, double salario)
        {

            this.bonusEmpleado = bonusEmpleado;

            this.salario = salario;

        }

        public double getSalario()
        {

            return salario + (double)bonusEmpleado;

        }

    }
}
