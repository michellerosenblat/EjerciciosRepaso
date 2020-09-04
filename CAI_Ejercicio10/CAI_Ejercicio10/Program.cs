using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
           char caracter;
            
           while (true)
            {
                do
            {
                Console.WriteLine("Ingrese un caracter");
            }
            while (!Char.TryParse(Console.ReadLine(), out caracter));

            if (Char.IsDigit(caracter))
            {
                Console.WriteLine("Es un dígito");
            }
            else {
                    if (Char.IsLetter(caracter))
                    {
                        if (isVowel(caracter))
                        {
                            Console.WriteLine("Es una vocal");
                        }
                        else
                        {
                            Console.WriteLine("Es una consonante");
                        }
                   
                }
                else
                    {
                        Console.WriteLine("Es un caracter especial");
                    }
            }
            Console.ReadLine();

            }

        }
        static bool isVowel(char letra)
        {
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            return vowels.Contains(Char.ToLower(letra));
            // char [] vowels = { 'a', 'e', 'i', 'o', 'u' };

        }
    }
}
