using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Devclara que a variavel MES é uma string
            string MES;


            //Captura o que usuario escrevel e armazena na variavel MES
            Console.Write("Entre o mes (por extenso): ");
            MES = Console.ReadLine();


            //Esse switch segue o mesmo exemplo do projeto anterior, analisando cada um dos cases abaixo, com base no que esta armazenado na variavel MES
            Console.WriteLine();
            switch (MES)
            {
                case "um": Console.WriteLine("Janeiro"); break;
                case "dois": Console.WriteLine("Fevereiro"); break;
                case "três": Console.WriteLine("Marco"); break;
                case "quatro": Console.WriteLine("Abril"); break;
                case "cinco": Console.WriteLine("Maio"); break;
                case "seis": Console.WriteLine("Junho"); break;
                case "sete": Console.WriteLine("Julho"); break;
                case "oito": Console.WriteLine("Agosto"); break;
                case "nove": Console.WriteLine("Setembro"); break;
                case "dez": Console.WriteLine("Outubro"); break;
                case "onze": Console.WriteLine("Novembro"); break;
                case "doze": Console.WriteLine("Dezembro"); break;
                    default: Console.WriteLine("Mes invalido"); break;
                    //Caso não encontre nenhuma informação semelhantre, o comando defalt sera ativado, exibindo a mensagem
            }

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();


        }
    }
}
