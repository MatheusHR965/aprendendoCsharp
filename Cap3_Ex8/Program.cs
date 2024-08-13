using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Quatro variaveis A, B e C para float que armazenam valores decimais
            float R, A, B;

            //Declara a variavvel OPCAO como inteiro
            int OPCAO;

            ////Converte os valores escritos para numeros decimais e armazena eles em A e B
            Console.Write("Informe o 1o. valor: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Informe o 2o. valor: ");
            B = float.Parse(Console.ReadLine());

            //Mostra na tela atraves do WriteLine, qual tipo de conta selecionar.
            Console.WriteLine();
            Console.WriteLine("[1] ........... Adiacao");
            Console.WriteLine("[2] ........ Subtracao");
            Console.WriteLine("[3] ..... Multiplicacao");
            Console.WriteLine("[4] ........... Divisao");
            Console.WriteLine();
            Console.Write("Escolha uma opcao --> ");
            OPCAO = int.Parse(Console.ReadLine());

            //Vai usar o Se e Senao para selecionar qual tipo de calculo vai utilizar

            //Adição
            if (OPCAO == 1)
            {
                R = A + B;
                Console.WriteLine("Resultado = " + R);
            }
            //Subtração
            if (OPCAO == 2)
            {
                R = B - A;
                Console.WriteLine("Resultado = " + R);
            }

            //Multiplicação
            if (OPCAO == 3)
            {
                R = A * B;
                Console.WriteLine("Resultado = " + R);
            }
            if (OPCAO == 4)
                if (B == 0)
                    Console.WriteLine("ERRO - Divisao por zero!");

                //Divisão
                else
                {
                    R = A / B;
                    Console.WriteLine("Resdultado = " + R);
                }
                    Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
