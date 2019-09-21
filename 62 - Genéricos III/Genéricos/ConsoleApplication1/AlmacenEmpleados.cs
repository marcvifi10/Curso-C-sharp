using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AlmacenEmpleados<T> where T: IParaEmpleados
    {

        private int i = 0;
        private T[] datosEmpleado;

        public AlmacenEmpleados(int z)
        {

            datosEmpleado = new T[z];

        }

        public void agregar(T obj)
        {

            datosEmpleado[i] = obj;

            i++;

        }

        public T getEmpleado(int i)
        {

            return datosEmpleado[i];

        }

    }
}
