using System;
using Gestione;
using System.Collections.Generic;

namespace Console_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeri;
            numeri = new List<int>();
            numeri.Add(1);
            numeri.Add(2);
            numeri.Add(3);
            numeri.Add(4);
            numeri.Add(5);

            int somma = 0;
            somma = Operazioni.Somma(numeri);
            Console.WriteLine(somma);
            Console.ReadLine();


        }
    }
}
