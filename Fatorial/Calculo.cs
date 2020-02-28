using System;
using System.Collections.Generic;

namespace Fatorial
{
    public class Calculo
    {
        public long CalcularFatorial(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("número inválido", nameof(numero));
            }
            else if (numero == 0)
            {
                return 1;
            }

            long fatorial = numero;

            var listaFatorial = new List<long>();

            while (numero > 1)
            {
                listaFatorial.Add(fatorial);
                fatorial *= (numero - 1);
                numero--;
            }

            return fatorial;
        }
    }
}
