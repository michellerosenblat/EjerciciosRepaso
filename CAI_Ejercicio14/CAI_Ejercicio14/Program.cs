using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
                int numero = 0;
                int tabla = 0;
                List<int> tablamultiplicar;
            
                do
                {
                    Console.WriteLine("Ingrese el número del que desee saber su tabla de multiplicar");

                }
                while (!int.TryParse(Console.ReadLine(), out numero));

                do
                {
                    Console.WriteLine("Ingrese hasta qué número de la tabla de multiplicar desea ver");

                }
                while (!int.TryParse(Console.ReadLine(), out tabla));

                tablamultiplicar = Enumerable.Range(1, tabla).ToList();
                foreach (int num in tablamultiplicar)
                {
                    Console.WriteLine(numero + " * " + num + " = " + (num * numero));
                }
                Console.ReadLine();
            }

        }
    }
}
