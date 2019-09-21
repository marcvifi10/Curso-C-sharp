using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AlmacenObjetos<T>
    {

        private T[] datosElemento;
        private int i = 0;

        public AlmacenObjetos(int z)
        {

            datosElemento = new T[z];

        }

        public void agregar(T obj)
        {

            datosElemento[i] = obj;

            i++;

        }

        public T getElemento(int i)
        {

            return datosElemento[i];

        }

    }
}
