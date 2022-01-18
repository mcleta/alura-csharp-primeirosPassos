using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 100; num++)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine(num);
                }
            }

            Console.ReadLine();
        }
    }
}
