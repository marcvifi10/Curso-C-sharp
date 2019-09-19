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

            int temperatura;

            Console.WriteLine("Entra una temperatura: ");
            temperatura = Convert.ToInt32(Console.ReadLine());

            if(temperatura < 0)
            {

                Console.WriteLine("Hace mucho frío!!!");

            }
            else if (temperatura < 10)
            {

                Console.WriteLine("Normal!!!");

            }
            else if (temperatura < 20)
            {

                Console.WriteLine("Hace calor!!!");

            }
            else
            {

                Console.WriteLine("Hace mucho calor!!!");

            }

        }
    }
}
