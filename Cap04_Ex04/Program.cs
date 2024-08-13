using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CRIA VARIAVEIS DO TIPO INTEIRO E STRING//
            int N, I, R;
            String RESP;

            //INICIALIZA A VARIUAVEL RESP COM S//
            RESP = "S";

            //REPETE O RESULTADO ENQUANTO FOR VERDADEIRO//
            while (RESP.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA - TABUADA");
                Console.WriteLine();
                Console.Write("Infore um valor: ");
                N = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //EXECUTA O BLOCO UM NUMERO ESPECIFICO DE VEZES//
                for (I = 1; I <= 10; I++)
                {
                    R = N * I;
                    Console.WriteLine("{0,2} x {1,2} = {2,3}", N, I, R);
                }

                Console.WriteLine();
                Console.WriteLine("Deseja continuar?");
                Console.Write("[S] para SIM ou [N] para NAO: ");
                RESP = Console.ReadLine();
                Console.WriteLine();
            }

        }
    }
}
