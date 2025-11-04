using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_C_
{
    internal class Ejer_7
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de numeros: ");
            int cant = int.Parse(Console.ReadLine());

            int[] num = new int[cant];
            Random random = new Random();

            Console.WriteLine("\nNumero generados");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(1, 51);
                Console.Write(num[i] + " ");
            }

            Console.Write("\nIngrese el numero a buscar: ");
            int buscar = int.Parse(Console.ReadLine());

            for (int i = 0; i < cant; i++)
            {
                if (num[i] == buscar)
                {
                    Console.WriteLine("Numero existe");
                    break;
                }
                else
                {
                    Console.WriteLine("Numero no existe");
                    break;
                }
            }
            Console.ReadKey();
        }
    }

}
