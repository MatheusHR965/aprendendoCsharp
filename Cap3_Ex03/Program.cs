using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variavel NUMERO é inteiro
            int NUMERO;

            //Converte essa string em numero inteiro que esta armazenado em NUMERO
            Console.Write("Entre um valor: ");
            NUMERO = int.Parse(Console.ReadLine());

            //Verifica se o valor é maioer ou igual a 20 e menor ou igual a 90
            Console.WriteLine();
            if (NUMERO >= 20 && NUMERO <= 90)
                Console.WriteLine("O valor esta entre 20 e 90");
            //Se sim, aparece o de cima, se não aparece o de baixo
            else
                Console.WriteLine("O valor nao esta entre 20 e 90");
            
            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
