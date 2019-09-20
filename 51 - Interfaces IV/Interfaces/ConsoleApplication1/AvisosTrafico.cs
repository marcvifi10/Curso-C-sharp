using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AvisosTrafico : IAvisos
    {

        private string remitente;

        private string mensaje;

        private string fecha;

        public AvisosTrafico()
        {

            remitente = "DGT";

            mensaje = "Sanción";

            fecha = "";

        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {

            remitente = this.remitente;

            mensaje = this.mensaje;

            fecha = this.fecha;

        }

        public string getFecha()
        {

            return fecha;

        }

        public void mostrarAviso()
        {

            Console.WriteLine("Mensaje enviado por " + remitente);

        }
    }
}
