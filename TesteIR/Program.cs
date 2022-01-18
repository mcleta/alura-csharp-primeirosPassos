using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste IR exe");
            
            double salario = 3300.0;

            if(salario >= 1900 && salario <= 2800)
                Console.WriteLine($"Teu salário é {salario}. A sua aliquota é de 7.5%. Você pode deduzir na declaração o valor de R$ 142.");

            if (salario >= 2800.01 && salario <= 3751)
                Console.WriteLine($"Teu salário é {salario}. A sua aliquota é de 15%. Você pode deduzir na declaração o valor de R$ 142.");

            if (salario >= 3751.01 && salario <= 4664)
                Console.WriteLine($"Teu salário é {salario}. A sua aliquota é de 22.5%. Você pode deduzir na declaração o valor de R$ 142.");

            Console.ReadLine();
        }
    }
}
