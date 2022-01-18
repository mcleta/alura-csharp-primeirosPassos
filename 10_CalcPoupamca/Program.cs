using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalcPoupamca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P10 exe");

            double valorInvest = 1000.00;

            int contMes = 01;

            int contMesTotal = 12;

            while (contMes <= contMesTotal)
            {
                valorInvest = valorInvest + valorInvest * 0.0036;
                Console.WriteLine($"Após {contMes} mês, você terá R${valorInvest}");
                contMes++;
            }

            Console.ReadLine();
        }
    }
}
