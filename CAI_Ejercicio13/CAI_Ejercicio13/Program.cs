using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            while (true) {
                int res;
                Console.WriteLine("Ingrese un numero");
                int.TryParse(Console.ReadLine(), out num);
                if (num > 0) { 
                List<int> numeros = Enumerable.Range(1, num-1).ToList();
                res = num;
                foreach (int numero in numeros)
                {
                    res = res * numero;
                }
                }
                else
                {
                    res = 0;
                }
                Console.WriteLine("Aca tenes el factorial " + res);
            }
        }
    }
}
