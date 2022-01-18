using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 1;
            int num2 = 10;
            int num3 = num2;

            for (int num = 1; num < num2; num++)
            {
                int num4 = num2 - num;

                num3 *= num4;

                Console.WriteLine(num3);
            }

            Console.ReadLine();
        }
    }
}
