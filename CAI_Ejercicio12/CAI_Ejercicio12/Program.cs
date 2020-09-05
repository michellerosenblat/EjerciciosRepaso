using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha1;
            DateTime fecha2;
            int dias;
            int anios;
            int meses;
            
            while (true) { 
                do
                {
                    Console.WriteLine("Ingrese la primera fecha");
                }
                while (!DateTime.TryParse (Console.ReadLine (), out fecha1));

                do
                {
                    Console.WriteLine("Ingrese la segunda fecha");
                }
                while (!DateTime.TryParse(Console.ReadLine(), out fecha2));

                dias = fecha2.Subtract(fecha1).Days;
                anios = dias/365;
                meses = dias % 365 / 30;
                dias = dias % 365 % 30;

                Console.WriteLine("Años: " + anios + " Meses: " + meses + " Días: " + dias);
            }

        }
    }
}
