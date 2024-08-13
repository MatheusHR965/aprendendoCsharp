using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variaveis abaixo são do tipo inteiro
            int DIVIDENTO, DIVISOR, QUOOCIENTE;

            //Ele altera o valor escrito pem console.write, converte para um valor inteiro e armazena na variavel definida
            Console.Write("Entre o valor do dividento ..:");
            DIVIDENTO = int.Parse(Console.ReadLine());

            Console.Write("Entre o valor do divisor ....:");
            DIVISOR = int.Parse(Console.ReadLine());

            //Ele vai dividir os valores aremazenados nas variaveis e depois vai armazenar na variavel definida
            QUOOCIENTE = DIVIDENTO / DIVISOR;

            Console.WriteLine();
            Console.WriteLine("Resultado = {0}", QUOOCIENTE);

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
