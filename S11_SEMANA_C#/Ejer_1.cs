using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_C_
{
    internal class Ejer_1
    {
        static void Main(string[] args)
        {
            int[] num = new int [5];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese numero: {i+1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nNumeros ingresados: ");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
