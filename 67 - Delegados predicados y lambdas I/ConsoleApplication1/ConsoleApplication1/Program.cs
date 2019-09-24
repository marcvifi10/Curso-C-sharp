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

            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);
            ElDelegado("Mensaje");

            ObjetoDelegado2 ElDelegado2 = new ObjetoDelegado2(MensajeDespedida.SaludoDespedida);
            ElDelegado2();

        }

        // Definición del objeto delegado
        delegate void ObjetoDelegado(string msj);
        delegate void ObjetoDelegado2();

    }
}
