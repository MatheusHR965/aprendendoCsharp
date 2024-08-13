using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //FAT serve para armazenar valores maiores//
            long FAT = 1, N, I;
            Console.Write("Informe um valor: ");
            N = long.Parse(Console.ReadLine());
            I = 1;

            //Vai repetir essa coluna ate ela ser verdadeira//
            do
            {
                FAT *= I;
                I++;
            }
            while (I <= N);
            Console.WriteLine();

            //VAi MOSTRAR O RESULTADO AQUI//
            Console.WriteLine("Factorial de {0} = {1}.", N, FAT);
            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
