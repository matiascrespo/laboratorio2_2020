﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioClase07;

namespace EjercicioClase07_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera t1 = new Tempera(ConsoleColor.Red, "Cualquiera", 5);
            Tempera t2 = new Tempera(ConsoleColor.Black, "Alba", 10);           
            Tempera t101 = new Tempera(ConsoleColor.Red, "Cualquiera", 200);


            
            Paleta p1 = new Paleta(5);
            Paleta p2 = new Paleta(5);
            Paleta p3 = new Paleta(5);
            Paleta p4 = new Paleta(5);
            Paleta p5 = new Paleta(5);
            Paleta p6 = new Paleta(5);

            p1 += t1;
            Console.WriteLine("***Paleta p1: ***\n" + p1.Mostrar());

            p2 += t101;
            Console.WriteLine("***Paleta p2: ***\n" + p2.Mostrar());

            p3 = p1 + p2;
            Console.WriteLine("***Paleta p3: ***\n" + p3.Mostrar());

            p4 += t2;
            Console.WriteLine("***Paleta p4: ***\n" + p4.Mostrar());

            p5 = p3 + p4;
            Console.WriteLine("***Paleta p5: ***\n" + p5.Mostrar());
            p6 = p5 + p1;
            Console.WriteLine("***Paleta p6: ***\n" + p6.Mostrar());


            Console.WriteLine("*******Lo muestro de nuevo..... y aparece el error.*******\n");

            Console.WriteLine("***Paleta p1: ***\n" + p1.Mostrar());
            Console.WriteLine("***Paleta p2: ***\n" + p2.Mostrar());
            Console.WriteLine("***Paleta p3: ***\n" + p3.Mostrar());
            Console.WriteLine("***Paleta p4: ***\n" + p4.Mostrar());
            Console.WriteLine("***Paleta p5: ***\n" + p5.Mostrar());












            Console.ReadKey();
        }
    }
}
