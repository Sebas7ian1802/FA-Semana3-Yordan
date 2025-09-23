using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SEMANA4_C_
{
    internal class SEMANA5
    {
        static void Main(string[] args)
        {
            int pares = 0, impares = 0, ceros = 0;

            Console.Write("Ingrese la cantidad de numeros: ");
            int cant = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for(int i = 1; i <= cant; i++)
            {
                Console.WriteLine($"Ingrese numero {i}:");
                int num=int.Parse(Console.ReadLine());

                if (num == 0) ceros++;
                else if (num % 2 == 0) pares++;
                else impares++;

            }

            Console.WriteLine("\n# pares" + pares);
            Console.WriteLine("# impares" + impares);
            Console.WriteLine("# ceros" + ceros);
        }     
    }
}
