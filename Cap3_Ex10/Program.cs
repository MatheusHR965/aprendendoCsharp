using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declara que a variavel MES é inteiro
            int MES;

            //Ele lê o comando como uma string e converte ela em um numero inteiro
            Console.Write("Entre os mes (numerico): ");
            MES = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //A estrutura switch pega o valor armazenado na variavel MES e compara com cada um dos cases para verificar se é real ou falso
            //Cada case termina com break para sair do switch apos o codigo correspondente ao case
            switch (MES)
            {
                case 1: Console.WriteLine("Janeiro"); break;
                case 2: Console.WriteLine("Fevereiro"); break;
                case 3: Console.WriteLine("Marco"); break;
                case 4: Console.WriteLine("Abril"); break;
                case 5: Console.WriteLine("Maio"); break;
                case 6: Console.WriteLine("Junho"); break;
                case 7: Console.WriteLine("Julho"); break;
                case 8: Console.WriteLine("Agosto"); break;
                case 9: Console.WriteLine("Setembro"); break;
                case 10: Console.WriteLine("Outubro"); break;
                case 11: Console.WriteLine("Novembro"); break;
                case 12: Console.WriteLine("Dezembro"); break;
                    // default é executado caso nenhum case corresponda com o numero armazenado na variavel MES
                    default: Console.WriteLine("Mes invalido"); break;
            }

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
