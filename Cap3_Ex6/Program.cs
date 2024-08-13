using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Quatro variaveis do tipo float que armazenam valores decimais
            float A, B, C, X;


            //Converte os valores escritos para numeros decimais
            Console.Write("Entre o valor <A>: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Entre o valor <B>: ");
            B = float.Parse(Console.ReadLine());
            Console.Write("Entre o valor <C>: ");
            C = float.Parse(Console.ReadLine());

            Console.WriteLine();
            if (!(C > 5))
                X = (A + B) * C;
            //Se C for igual a dez, conta de cima. Se não conta de baixo
            else
                X = (A - B) * C;

            Console.WriteLine("O resultado de X equivale a: " + X);

            Console.WriteLine();
            Console.Write("Tecla <Emter> para encerrar... ");
            Console.WriteLine();

        }
    }
}
