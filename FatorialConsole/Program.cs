using System;
using System.Collections.Generic;

namespace FatorialConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            Console.WriteLine($"Cálculo fatorial do número: {numero}");

            if (numero < 0)
            {
                Console.WriteLine($"número inválido: {numero}");
            }
            // comparação numero igual a zero
            else if (numero == 0)
            {
                Console.WriteLine("O resultado é: 1");
            }
            else
            {
                long fatorial = numero;

                //nova lista do tipo primitivo long para utilizar no retorno
                var listaFatorial = new List<long>();

                Console.WriteLine("***********************");
                // laço de repetição while - enquanto não satisfazer a condição a logica continua execuando o laço
                while (numero > 1)
                {
                    Console.WriteLine($"While --- antes do calculo : {fatorial}");
                    // add a variavel fatorial na lista
                    listaFatorial.Add(fatorial);

                    // multiplicar o valor da variavel fatorial pelo valor da variavel número
                    fatorial *= (numero - 1);

                    Console.WriteLine($"While --- depois do calculo: {fatorial}");

                    // decrementar o valor da variavel numero
                    numero--;
                    Console.WriteLine($"While --- valor numero: {numero}");
                }

                Console.WriteLine("***********************");

                Console.WriteLine($"Resultado fatorial : {fatorial}");
            }

            Console.ReadKey();
        }
    }
}
