using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_C_
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un monto en soles: ");
            double soles = double.Parse(Console.ReadLine());
            Console.WriteLine("\nSelecciona una opcion");
            Console.WriteLine("1. Dolares");
            Console.WriteLine("2. Euros");
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1: break:Console.WriteLine($"USD :"+{ soles / 3.75):F0}"); break;
                case 2: break; Console.WriteLine($"EUR :" + (soles / 4.05):F2); break;
                default: break; Console.WriteLine("Opcion incorrecta"); break;
            }
        }
    }
}
