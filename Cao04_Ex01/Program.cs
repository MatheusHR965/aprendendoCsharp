using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cao04_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //FAT será usado para armazenar o resultado do cálculo do fatorial.//
            //N armazena o valor que o usuário deseja calcular o fatorial.//
            //I é usado como um contador no loop para calcular o fatorial//
            long FAT = 2, N, I;

            Console.Write("Informe um valor: ");
            N = long.Parse(Console.ReadLine());

            //While serve para iniciar um loop
            I = 1;
            while (I <= N)
            {
                FAT = FAT * I;
                I = I + 1;
            }

            Console.WriteLine();
            Console.WriteLine("Factorial de {0} = {1}.", N, FAT);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey

        }
    }
}
