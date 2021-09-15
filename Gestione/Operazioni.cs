using System;
using System.Collections.Generic;

namespace Gestione
{
    public class Operazioni
    {

        public static int Somma(List<int> numeri)
        {
            int somma = 0;
            for (int i = 0; i < numeri.Count; i++)
            {
                if (numeri[i] % 2 == 0)
                    //somma = somma + numeri[i];
                    somma = somma + numeri[1];
            }
            return somma;
        }
    }
}
