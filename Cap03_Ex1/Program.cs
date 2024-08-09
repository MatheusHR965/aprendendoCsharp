using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int A, B, R;

            Console.Write("Entre o valor <A>: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Entre o valor <B>: ");
            B = int.Parse(Console.ReadLine());

            R = A + B;

            Console.WriteLine();
            if (R > 10)
                Console.WriteLine("Resultado = {0}", R);

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();


        }
    }
}
