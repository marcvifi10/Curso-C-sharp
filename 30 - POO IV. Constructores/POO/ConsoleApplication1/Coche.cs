using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Coche
    {

        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private String tapiceria;


        public Coche()
        {

            ruedas = 4;
            largo = 15.00;
            ancho = 10.00;
            climatizador = false;
            tapiceria = "";

        }

        public int Ruedas
        {

            get
            {

                return ruedas;

            }

            set
            {

                ruedas = value;

            }

        }

    }
}
