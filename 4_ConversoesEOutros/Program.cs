using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P4 exe");

            double salario = 1200.50;
            Console.WriteLine(salario);

            //O int é um tipo de variável que suporta valores até 32 bits
            int salarioInt = (int)salario;
            Console.WriteLine(salarioInt);

            // O long é uma variável de 64 bits
            long idade;
            idade = 130000000000000;
            Console.WriteLine(idade);

            //O short é um tipo de variável de 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
