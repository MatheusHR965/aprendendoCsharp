﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for ( int I = 1; I <= 10; I += 2)
                Console.WriteLine("I = {0}", I);
            Console.WriteLine();

            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
