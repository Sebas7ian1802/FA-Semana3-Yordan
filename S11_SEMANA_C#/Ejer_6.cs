using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_C_
{
    internal class Ejer_6
    {
        static void Main(string[] args)
        {
            string[] productos = new string[5];
            int registrados = 0;

            for (int i = 0; registrados < 5; i++)
            {
                Console.Write($"Ingrese producto {registrados+1}: ");
                string pro = Console.ReadLine();
                bool duplicado = false;
                // Verificar si el producto ya fue registrado
                for (int j = 0; j < registrados; j++)
                { 
                    if (productos[j] == pro)
                    {
                     Console.WriteLine("Producto ya registrado.\n");
                        duplicado = true;
                        break;
                    }
                }
                //Si no es duplicado (falso) lo registramos
                if (duplicado == false)
                { 
                    productos[registrados] = pro;
                    registrados++;
                }
            }
            Console.WriteLine("\nProductos registrados:");
            foreach (string p in productos)
                Console.WriteLine(p);
        }
    }
}
