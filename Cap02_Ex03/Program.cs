using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Define as variaves para o tipo float que aceita armazenar numeros em casas decimais
            //HT Horas trabalhadas, VH Valor por Hora, PD Percentual de Desconto, SB Salario Bruto, TD Total de Desconto, SL Salario Liquido.
            float HT, VH, PD, SB, TD, SL;

            //Armazena os valores digitados nas variaveis HT, VH, PD.
            Console.Write("Horas Trabalhadas ...........:");
            HT = float.Parse(Console.ReadLine());
            Console.Write("Valor hora ...............:");
            VH = float.Parse(Console.ReadLine());
            Console.Write("Valor do percentual de desconto .:");
            PD = float.Parse(Console.ReadLine());

            //Calcula os valores e armazena nas variavewis SB, TD, SL.
            SB = HT * VH;
            TD = (PD / 100) * SB;
            SL = SB - TD;

            //Mostra o salário líquido SL no formato monetário, com duas casas decimais, usando o método ToString
            Console.WriteLine();
            Console.Write("Salario liquido ................:");
            Console.WriteLine(SL.ToString("##,##0.00"));

            Console.WriteLine();
            Console.Write("Tecla <Enter> oara encerrar...");
            Console.WriteLine();

        }
    }
}
