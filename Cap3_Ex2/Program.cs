using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Define a variavei A, B e R como inteiras
            int A, B, R;

            //Armazena os valores escritos em A e B.
            Console.Write("Entre o valor <A>: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Entre o valor <B>: ");
            B = int.Parse(Console.ReadLine());


            //Soma A e B e armazena em R
            R = A + B;

            Console.WriteLine();
            if (R > 10)
                Console.WriteLine("Resultado ultrapassa dez.");
            //Se R for maior que 10, aparece o de cima. Se não, aparece o de baixo
            else
                Console.WriteLine("Resultado não ultrapassa dez.");

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
