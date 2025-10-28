using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_C_
{
    internal class Ejer_4
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese Número {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("\nNúmeros ingresados:");


            foreach (int i in num)
                Console.Write(i+" ");

            Console.WriteLine("\nNúmeros pares:");
            for (int i = 0; i < num.Length; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
