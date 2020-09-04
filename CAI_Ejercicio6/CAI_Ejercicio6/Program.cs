using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int resultado = 0;
            Console.WriteLine("Ingrese el primer numero");

            while (!Int32.TryParse(Console.ReadLine(), out numero1)) {
                Console.WriteLine("Ingrese nuevamente el primer numero");
            }
            Console.WriteLine(numero1);

            Console.WriteLine("Ingrese el segundo numero");
            while (!Int32.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("Ingrese nuevamente el segundo numero");
            }

            resultado = (numero1 + numero2) * (numero1 - numero2);

            Console.WriteLine("El resultado es " + resultado);
            Console.ReadLine();

        }
    }
}
