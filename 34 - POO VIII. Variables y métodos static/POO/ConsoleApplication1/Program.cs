﻿using System;
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

            realizarTarea();

        }

        static void realizarTarea()
        {

            Punto origen = new Punto(2,3);

            Punto destino = new Punto();

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine("La distancia es: " + distancia);

            Console.WriteLine("Número de objetos: " + Punto.ContadorDeObjetos());

        }

    }
}
