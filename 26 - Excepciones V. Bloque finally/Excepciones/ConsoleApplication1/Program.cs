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

            System.IO.StreamReader archivo = null;

            try
            {

                string linea;

                int contador = 0;

                string path = @"C:\Users\marcv\OneDrive\Escritorio\tirar.txt";

                archivo = new System.IO.StreamReader(path);

                while((linea = archivo.ReadLine()) != null)
                {

                    Console.WriteLine(linea);

                    contador++;

                }

            }
            catch (Exception e)
            {

                Console.WriteLine("ERROR!!!");

            }
            finally
            {

                Console.WriteLine("Comprobado!!!");

            }

        }
    }
}
