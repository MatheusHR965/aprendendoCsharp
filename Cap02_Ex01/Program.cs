﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //declara a variavel nome para o tipo string
            string NOME;

            //Armazena o valor escrito ns variavel nome
            Console.Write("Entre seu nome");
            NOME = Console.ReadLine();
            Console.WriteLine("Ola," + NOME);

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
