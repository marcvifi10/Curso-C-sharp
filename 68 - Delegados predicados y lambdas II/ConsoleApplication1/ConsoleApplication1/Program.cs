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

            List<int> listaNumeros = new List<int>();

            listaNumeros.AddRange(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});

            // Declaramos el delegado predicado1

            Predicate<int> elDelegadoPred1 = new Predicate<int>(DamePares);

            List<int> numPares = listaNumeros.FindAll(elDelegadoPred1);

            foreach(int num in numPares)
            {

                Console.WriteLine(num);

            }

            Console.WriteLine();

            // Declaramos el delegado predicado2

            Predicate<int> elDelegadoPred2 = new Predicate<int>(DameImpares);

            List<int> numImpares = listaNumeros.FindAll(elDelegadoPred2);

            foreach (int num in numImpares)
            {

                Console.WriteLine(num);

            }

            Console.WriteLine();

            //------------------------------------------------------

            List<Personas> gente = new List<Personas>();

            Personas p1 = new Personas();
            p1.Nombre = "Juan";
            p1.Edad = 22;

            Personas p2 = new Personas();
            p2.Nombre = "Maria";
            p2.Edad = 28;

            Personas p3 = new Personas();
            p3.Nombre = "Ana";
            p3.Edad = 37;

            gente.AddRange(new Personas[] {p1, p2, p3});

            Predicate<Personas> elPredicado = new Predicate<Personas>(ExisteJuan);

            bool existe = gente.Exists(elPredicado);

            if(existe == true)
            {

                Console.WriteLine("Existe Juan!!!");

            }
            else
            {

                Console.WriteLine("NO existe Juan!!!");

            }

            Console.WriteLine();

        }

        static bool DamePares(int num)
        {

            if(num % 2 == 0)
            {

                return true;

            }
            else
            {

                return false;

            }

        }

        static bool DameImpares(int num)
        {

            if (num % 2 == 1)
            {

                return true;

            }
            else
            {

                return false;

            }

        }

        //--------------------------------------------------------------------------

        static bool ExisteJuan(Personas persona)
        {

            if(persona.Nombre == "Juan")
            {

                return true;

            }
            else
            {

                return false;

            }

        }

    }
}
