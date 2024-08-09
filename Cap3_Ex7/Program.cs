using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float A, B, C;

            Console.Write("Informe o lado A: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Informe o lado B: ");
            B = float.Parse(Console.ReadLine());
            Console.Write("Informe o lado C: ");
            C = float.Parse(Console.ReadLine());

            Console.WriteLine();
            if (A < B && B < A + C && C < A + B)
                if (A == B && B == C)
                    Console.WriteLine("Triangulo Equilatero");
                else
                    Console.WriteLine("Tringulo Escaleno");
            else
                Console.WriteLine("Valores nao formam um triangulo");

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
