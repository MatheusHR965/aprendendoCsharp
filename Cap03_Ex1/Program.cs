using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //três variaveis do tipo inteira
            int A, B, R;

            //deve inserir os valores em cada parte e eles serao armazenados em A e B
            Console.Write("Entre o valor <A>: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Entre o valor <B>: ");
            B = int.Parse(Console.ReadLine());

            //Vai somar os valores A e B e vai armazenar no R
            R = A + B;

            Console.WriteLine();
            if (R > 10)
                Console.WriteLine("Resultado = {0}", R);

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();


        }
    }
}
