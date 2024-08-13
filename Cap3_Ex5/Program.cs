using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Serve para armazenar dois nomes e dois generos para o tipo string.
            string NOME1, NOME2, SEXO1, SEXO2;

            //Armazena os nomes e os generos nas vatriaveis NOME e SEXO
            Console.Write("Entre o 1o.nome .......: ");
            NOME1 = Console.ReadLine();
            Console.Write("Entre o sexo do 1o.nome ..: ");
            SEXO1 = Console.ReadLine();

            Console.Write("Entre o 2o.nome ........: ");
            NOME2 = Console.ReadLine();
            Console.Write("Entre o sexo do 2o.nome ..: ");
            SEXO2 = Console.ReadLine();

            //Se sexo1 e 2 for igual a M, NOME1 dança com NOME2
            Console.WriteLine();
            if (SEXO1 == "M" ^ SEXO2 == "M")
                Console.WriteLine(NOME1 + "danca com" + NOME2);
            //se nao, NOME1 não dança com NOME2
            else
                Console.WriteLine(NOME1 + "nao danca com" + NOME2);

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.WriteLine();

        }
    }
}
