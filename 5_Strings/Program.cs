using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P5 exe");

            //Em C# o char é a tipagem onde a variavel tem, apenas, 1 caracter e deve-se usar '' para diferenciar dos demais textos
            char letra = 'a';
            Console.WriteLine(letra);

            letra = (char)65;
            Console.WriteLine(letra);

            letra = (char)61;
            Console.WriteLine(letra);

            letra = (char)(letra + 2);
            Console.WriteLine(letra);

            string texto = "abc";
            Console.WriteLine(texto);

            texto = texto + letra;
            Console.WriteLine(texto);

            string lista = "abc" + 
                "def" + 
                "ghi" +
                "jkl";
            Console.WriteLine(lista);

            string lista2 = @"
abc 
def
ghi
jkl
            ";
            Console.WriteLine(lista2);

            Console.ReadLine();
        }
    }
}
