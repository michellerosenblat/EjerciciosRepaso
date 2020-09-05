using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto= "";
            List <string> campos;
            string edad;
            Console.WriteLine("Ingrese su nombre, apellido y edad");
            do
            {
                texto = Console.ReadLine();
            }
            while (texto == "");

            campos = texto.Split(' ').ToList<string>();
            edad =campos.Find (cadena => IsNumber (cadena));
            campos.Remove(edad);
            Console.WriteLine("Nombre: " + campos[0] + " Apellido: " + campos[1] + " Edad: " + edad);
            Console.ReadLine();
            
        }
        static bool IsNumber (string cad)
        {
            return cad.All(caracter => char.IsNumber(caracter));
        }
    }
}
