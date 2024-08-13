using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CODIGO é cariavel inteiro
            int CODIGO;

            //converte a string em um número inteiro, que é armazenado na variável CODIGO.
            Console.Write("Entre o codigo de acesso: ");
            CODIGO = int.Parse(Console.ReadLine());

            //Se codigo for igual a 1, 2 e 3
            Console.WriteLine();
            if (CODIGO == 1 || CODIGO == 2 || CODIGO == 3)
            {
                //Se CODIGO for igual a 1, 2 e 3, aparece abaixo
                if (CODIGO == 1)
                    Console.WriteLine("um");
                if (CODIGO == 2)
                    Console.WriteLine("dois");
                if (CODIGO == 3)
                    Console.WriteLine("tres");
            }

            //Se não aparece o debaixo
            else
                Console.WriteLine("codigo invalido");

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
