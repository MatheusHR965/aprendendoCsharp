using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //As variaveis abaixo são do tipo inteiro
            int DIVIDENDO, DIVISOR, QUOCIENTE;

            //Pega os valores digitados e altera eles para o tipo inteiro e armazena eles
            Console.Write("Entre o valor do dividento ..: ");
            DIVIDENDO = int.Parse(Console.ReadLine());

            Console.Write("Entre o valor do divisor ....: ");
            DIVISOR = int.Parse(Console.ReadLine());

            try
            {
                QUOCIENTE = DIVIDENDO / DIVISOR;

                Console.WriteLine();
                Console.WriteLine("Resultado = {0}", QUOCIENTE);
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine();
                Console.WriteLine("Erro - divisao por zero");
            }

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
