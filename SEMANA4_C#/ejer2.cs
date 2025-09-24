using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_Csharp
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un año: ");
            int year = int.Parse(Console.ReadLine()!);

            if (year % 4 == 0 && year %100 != 0 || year %400 ==0) 
            {
                Console.WriteLine("Año bisiesto");
            }
            else
            {
                Console.WriteLine("Año no bisiesto");
            }

            if (year % 2 == 0)
            {
                Console.WriteLine("Año par");
            }
            else
            {
                Console.WriteLine("Año impar");
            }
        }
    }
}
