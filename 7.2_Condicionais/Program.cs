using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P7.2 exe");

            int idadeJao = 16;

            bool companhiaMais18 = false;

            if (companhiaMais18 == true || idadeJao >= 18)
            {
                Console.WriteLine("Passa");
            }
            else
            {
                 Console.WriteLine("VAZA!!!!!!!!!!!");
            }

            Console.ReadLine();
        }
    }
}
