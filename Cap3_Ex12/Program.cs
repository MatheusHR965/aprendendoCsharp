using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declara as variaveis NR e PEDIDO como inteiros
            int NR, PEDIDO;

            //Cria uma instancia da classe Random chamada RANDOMICO, serve para criar numeros aleatorios entre 1 e 6. E depois armazena o valor na variavel NR
            Random RANDOMICO = new Random();
            NR = RANDOMICO.Next(1, 6);

            //CAptura o que escreve na entrada abaixo em string, e converte para um valor inteiro para
            Console.Write("Entre um numro entre 1 e 5: ");
            PEDIDO = int.Parse(Console.ReadLine());


            //Verifica se o numero inserido em PEDIDO é igual ao valor aleatorio armazenado em NR
            Console.WriteLine();
            if (PEDIDO == NR)
                Console.WriteLine("Acertou - foi sorteado: {0}.", NR);

            //Se não, aparece a mensagem abaixo
            else
                Console.WriteLine("Errou - foi sorteado: {0}.", NR);

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}