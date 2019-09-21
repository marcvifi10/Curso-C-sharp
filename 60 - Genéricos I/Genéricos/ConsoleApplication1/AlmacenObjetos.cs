using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AlmacenObjetos
    {

        private Object[] datosElemento;
        private int i = 0;

        public AlmacenObjetos(int z)
        {

            datosElemento = new Object[z];

        }

        public void agregar(Object obj)
        {

            datosElemento[i] = obj;

            i++;

        }

        public Object getElemento(int i)
        {

            return datosElemento[i];

        }

    }
}
