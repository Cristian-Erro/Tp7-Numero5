﻿using System;

namespace Numero5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro;
            int resultado;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--Bienvenido al sistema de factoriales---");

            Console.WriteLine("Ingrese el numero a calcular su factorial");
            nro = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
           
            resultado=factorial(nro);
            
            Console.WriteLine("El factorial del numero " + nro + " es " +resultado);
            Console.WriteLine("----Gracias por utilizar mi programa!----");
            
        }
        static int factorial(int nro)
        {
            int facto=1;
            for (int i = 1; i <= nro; i++)
            {
                facto = facto * i;
            }
            return facto;
        }
    }
}
