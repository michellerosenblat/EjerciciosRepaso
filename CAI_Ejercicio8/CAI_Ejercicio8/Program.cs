using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1;
            DateTime d2;

            Console.WriteLine("Ingrese la primera fecha");

            while (!(DateTime.TryParse(Console.ReadLine (), out d1))){ 
            Console.WriteLine("Ingrese de nuevo la primera fecha");
            }
            Console.WriteLine("Ingrese la segunda fecha");

            while (!(DateTime.TryParse(Console.ReadLine(), out d2))){
                Console.WriteLine("Ingrese de nuevo la segunda fecha");
            }

            Console.WriteLine((d2 - d1).TotalDays);

            Console.ReadLine();

        }
    }
}
