using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P6 exe");

            int idadeJose = 55;

            int idadeGu = idadeJose;

            Console.WriteLine("Jose tem " + idadeJose + " anos e Gu tem " + idadeGu + " anos");

            Console.ReadLine();
        }
    }
}
