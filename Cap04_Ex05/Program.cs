using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //INFORMA QUE A VARIAVEL SERA INTEIRO//
            int N, I, R;

            Console.WriteLine("PROGRAMA - TABUADA - v2.0");
            Console.WriteLine();
            Console.Write("Informe um valor: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //EXECUTA O CODIGO UM NUMERO EXPECIFICO DE VEZES//
            for (I = 1; I <= 10; I++)
            {
                //Cálculo da tabuada propriamente dito
                R = N * I;
                //Apresentação da tabuada no formato: N X I = R
                Console.WriteLine("{0,2} X {1,2} = {2,3}", N, I, R);
            }

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
