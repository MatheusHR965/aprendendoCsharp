using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CRIA AS VARIAVEIS DO TIPO INTEIRO E ARMAZENA O 1//
            int VALOR = 1, RESULTADO;


            //ARMAZENA O VALOR E INCREMENTA UM NUMERO A MAIS//
            RESULTADO = VALOR++;
            Console.WriteLine("RESULTADO = {0}", RESULTADO);
            Console.WriteLine("VALOR     = {0}", VALOR);
            Console.WriteLine();

            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
