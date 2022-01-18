using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num2 = 1;

            for (int contLinha = 1; contLinha <= 10; contLinha++)
            {
                for (int num = 1; num <= 10; num++)
                {
                    Console.WriteLine($"{num2} * {num} = { num * num2 }");
                }

                Console.Write("\r\n");

                num2++;
            }

            Console.ReadLine();
        }
    }
}
