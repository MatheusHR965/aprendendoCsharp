﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ARMAZENA VALORES MUITO MAIORES//
            long FAT = 1, N, I;

            Console.Write("Informe um valor: ");
            N = long.Parse(Console.ReadLine());

            //CONTROLA A QUANTIDADE DE VEZES QUE O CODIGO VAI FUNCIONAR//
            for (I = 1; I <= N; I++)
                FAT *= I;

            Console.WriteLine();
            Console.WriteLine("Fatorial de {0} = {1}.", N, FAT);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
