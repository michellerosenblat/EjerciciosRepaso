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
            

            Console.WriteLine("Ingrese la fecha a comparar");

            while (!(DateTime.TryParse(Console.ReadLine (), out d1))){ 
            Console.WriteLine("Ingrese de nuevo la fecha");
            }
           
            Console.WriteLine((d1- DateTime.Now).TotalDays);

            Console.ReadLine();

        }
    }
}
