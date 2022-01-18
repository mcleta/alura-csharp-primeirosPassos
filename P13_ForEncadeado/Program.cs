using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P13 exe");

            for (int contLinha = 0; contLinha <= 10; contLinha++)
            {
                for (int contColuna = 0; contColuna <= 10; contColuna++)
                {
                    Console.Write("*");

                    if (contColuna >= contLinha)
                        break;
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
