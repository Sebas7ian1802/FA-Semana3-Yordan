using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_Csharp
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un monto en soles: ");
            double soles = double.Parse(Console.ReadLine()!);
            Console.WriteLine("\nSelecciona una opción");
            Console.WriteLine("1. Dólares");
            Console.WriteLine("2. Euros");
            int opcion = int.Parse(Console.ReadLine()!);
            switch(opcion)
            {
                case 1:
                    Console.WriteLine($"USD: {soles / 3.75:F2}"); // Muestra con 2 decimales para precisión
                    break;

                case 2:
                    Console.WriteLine($"EUR: {soles / 4.05:F2}");
                    break;

                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }
        }
    }
}
