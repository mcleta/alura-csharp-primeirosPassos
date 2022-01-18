using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P8 exe");

            int idadeJao = 16;

            bool companhiaMais18 = true;

            string mensagemAdicinal = "";

            string mensagem18;

            if (idadeJao >= 18)
            {
                mensagem18 = "É maior de idade.";
            }
            else
            {
                mensagem18 = "Não é maior de idade.";
            }

            if (companhiaMais18 == true)
            {
                mensagemAdicinal = "Ta acompanhado.";
            }
            else
            {
                mensagemAdicinal = "Não ta acompanhado.";
            }

            if (companhiaMais18 == true && idadeJao >= 18)
            {
                Console.WriteLine(mensagem18);
                Console.WriteLine(mensagemAdicinal);
                Console.WriteLine("Passa");
            }
            else
            {
                Console.WriteLine(mensagem18);
                Console.WriteLine(mensagemAdicinal);
                Console.WriteLine("VAZA!!!!!!!!!!!");
            }

            Console.ReadLine();
        }
    }
}
