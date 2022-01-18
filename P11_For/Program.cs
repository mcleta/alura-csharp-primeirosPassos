using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalcPoupamca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P11 exe");

            double valorInvest = 1000.00;

            int contMesTotal = 12;

            for (int contMes = 1; contMes <= contMesTotal; contMes++)
            {
                valorInvest *= 1.0036;
                Console.WriteLine($"Após {contMes} mês, você terá R${valorInvest}");
            }

            Console.ReadLine();
        }
    }
}
