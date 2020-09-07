using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro;
            string hexa;
            string octal;
            string binario;
            
            do
            {
                Console.WriteLine("Ingrese un numero");
            }
            while (!int.TryParse(Console.ReadLine(), out nro));

            binario = ConvertirABinario(nro);
            hexa = ConvertirAHexadecimal(nro);
            octal= ConvertirAOctal(nro);

            Console.WriteLine("En binario es: " + binario);
            Console.WriteLine("En hexadecimal es: " + hexa);
            Console.WriteLine("En octal es: " + octal);
            Console.ReadLine();

            
        }

        static string ConvertirAHexadecimal (int valor) {
            return valor.ToString("X");
        }
        static string ConvertirABinario(int valor)
        {
            return Convert.ToString(valor, 2);
        }
        static string ConvertirAOctal(int valor)
        {
            return Convert.ToString(valor, 8);
        }
    }
}
