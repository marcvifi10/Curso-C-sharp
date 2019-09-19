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

            int n;

            try
            {

                Console.WriteLine("Entra un número: ");
                n = Convert.ToInt32(Console.ReadLine());

            }
            catch(Exception e)
            {

                Console.WriteLine("Valor NO válido!!!");

            }
            finally
            {

                Console.WriteLine("Comprobado!!!");

            }

        }
    }
}
