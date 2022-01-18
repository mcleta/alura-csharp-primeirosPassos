using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P7 exe");

            int idadeJao = 16;

            bool companhiaMais18 = false;

            if (companhiaMais18 == true)
            {
                Console.WriteLine("passem");
            }
            else
            {
                Console.WriteLine("Não tem companhia, então verifico a idade.");

                if (idadeJao >= 18)
                {
                    Console.WriteLine("Tu é maior, passa");
                }
                else
                {
                    Console.WriteLine("Não é maior, vaza!!!!!!!!!!!");
                }
            }

            Console.ReadLine();
        }
    }
}
