using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string password ="michelle";
            
            while (true) {
            int i = 1;
            bool correcta = false;
                do
                {
                    Console.WriteLine("Ingrese la contraseña");
                    if (Console.ReadLine() == password)
                    {
                        Console.WriteLine("Contraseña correcta");
                        correcta = true;
                    
                    }
                    else
                    {
                        if (i == 3)
                        {
                            Console.WriteLine("Clave bloqueada");
                        }
                        else { 
                        Console.WriteLine("Acceso denegado. La contraseña no es correcta");
                            i++;
                        }
                    }
                }
                while (i <= 3 && correcta ==false);
                }
        }
    }
    }

