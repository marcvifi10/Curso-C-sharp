using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Vehiculo
    {

        public void ArrancarMotor(string sonidoAlArrancar)
        {

            Console.WriteLine("Arranca el motor " + sonidoAlArrancar);

        }

        public void PararMotor(string sonidoAlParar)
        {

            Console.WriteLine("Parando el motor " + sonidoAlParar);

        }

        public virtual void Conducir()
        {

            Console.WriteLine("Conduzco");

        }

    }
}
