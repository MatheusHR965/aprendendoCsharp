using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DEFINE QUE AS VARIAVEIS SÃO INTEIROS E ACRECENTA // EM UMA DELAS//
            int VALOR = 1, RESULTADO;

            RESULTADO = ++VALOR;
            Console.WriteLine("RESULTADO = {0}", RESULTADO);
            Console.WriteLine("VALOR     = {0}", VALOR);
            Console.WriteLine();

            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
