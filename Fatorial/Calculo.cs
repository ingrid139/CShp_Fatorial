using System;
using System.Collections.Generic;

namespace Fatorial
{
    // classe de teste proposta pelo desafio
    public class Calculo
    {
        //lógica a ser desenvolvida
        public long CalcularFatorial(int numero)
        {
            // comparação numero menor que zero
            if (numero < 0)
            {
                throw new ArgumentException("número inválido", nameof(numero));
            }
            // comparação numero igual a zero
            else if (numero == 0)
            {
                return 1;
            }

            long fatorial = numero;

            //nova lista do tipo primitivo long para utilizar no retorno
            var listaFatorial = new List<long>();

            // laço de repetição while - enquanto não satisfazer a condição a logica continua execuando o laço
            while (numero > 1)
            {
                // add a variavel fatorial na lista
                listaFatorial.Add(fatorial);

                // multiplicar o valor da variavel fatorial pelo valor da variavel número
                fatorial *= (numero - 1);

                // decrementar o valor da variavel numero
                numero--;
            }

            return fatorial;
        }
    }
}
