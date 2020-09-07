using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                int nro;
                int cantidadPrimos = 0;
                do
                {
                    Console.WriteLine("Ingrese hasta que numero quiere saber la cantidad de primos");
                }
                while (!int.TryParse(Console.ReadLine(), out nro));
                if (!(nro == 1 || nro == 0))
                {
                    List<int> valoresposibles = Enumerable.Range(2, nro - 1).ToList();
                    cantidadPrimos = valoresposibles.FindAll(numero => EsNumeroPrimo(numero)).Count();

                }
                Console.WriteLine("La cantidad de números primos es " + cantidadPrimos);
                Console.WriteLine("El factorial de " + nro + " es " + FactorialDe(nro));
            Console.ReadLine();
            }

        }
        static bool EsNumeroPrimo (int valor)
        {
            //El uno no es primo https://infoymate.es/mate/errores/uno.htm#:~:text=El%20n%C3%BAmero%201%20no%20es,porque%20solo%20tiene%20un%20divisor.
            List<int> valores = Enumerable.Range(2, (valor - 2)).ToList();
            return valor == 2 || valores.All(val => (valor % val != 0));          
        }

        static int FactorialDe (int valor)
        {
            int res;
            if (valor > 0)
            {
                List<int> numeros = Enumerable.Range(1, valor - 1).ToList();
                res = valor;
                foreach (int numero in numeros)
                {
                    res = res * numero;
                }
            }
            else
            {
                res = 0;
            }
            return res;
        }

    }
}
