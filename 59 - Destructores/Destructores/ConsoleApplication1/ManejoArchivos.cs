using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ManejoArchivos
    {

        StreamReader archivo = null;

        int contador = 0;

        string linea;


        public ManejoArchivos()
        {

            archivo = new StreamReader(@"C:\texto.txt");

            while((linea = archivo.ReadLine()) != null)
            {

                Console.WriteLine(linea);

                contador++;

            }

        }

        public void mensaje()
        {

            Console.WriteLine("Hay " + contador + " líneas.");

        }

        // Destructor
        ~ManejoArchivos()
        {

            archivo.Close();

        }

    }
}
