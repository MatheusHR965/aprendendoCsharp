using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declara as variaveis A, B, R do tipo inteiro
            int A, B, R;

            //Armazena os valores nas variaveis A e B 
            Console.Write("Entre o 1o. valor: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Entre o 2o. valor: ");
            B = int.Parse(Console.ReadLine());

            //Soma A e B e armazena na variaveu R
            R = A + B;

            //Mostra o resultado abaixo
            Console.WriteLine();
            Console.WriteLine("Resultado = " + R);

            Console.WriteLine();
            Console.Write("Tecla <Enter> para continuar... ");
            Console.ReadLine();

        }
    }
}
