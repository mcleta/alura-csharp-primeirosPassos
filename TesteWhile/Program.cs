using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        int contador = 1;

        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }
    }
}