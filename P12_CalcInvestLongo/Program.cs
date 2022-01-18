using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalcInvestLongo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P11 exe");

            double valorInvest = 1000.00;

            double fatorRend = 1.0036;

            int contMesTotal = 12;

            int contAnoTotal = 5;

            for (int contAno = 1; contAno <= contAnoTotal; contAno++)
            {
                for (int contMes = 1; contMes <= contMesTotal; contMes++)
                {
                    valorInvest *= fatorRend;
                }

                fatorRend += 0.0010;
            }

            Console.WriteLine($"Após {contAnoTotal} anos de investimento, você terá R${valorInvest}");

            Console.ReadLine();
        }
    }
}
