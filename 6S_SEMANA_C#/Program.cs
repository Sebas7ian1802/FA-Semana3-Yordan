using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA6_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejer 1 Velidadcion de contraseña

            Console.Write("Genere una contraseña: ");
            string g = Console.ReadLine();

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("-           Valide su contraseña      -");
            Console.WriteLine("-------------------------------------\n");

            Console.Write("Ingrese su contraseña: ");
            string intento /* O tambien (i) */ = Console.ReadLine();

            int intentos = 3;
            while (intentos > 0)
            {
                Console.Write("Ingrese su contraseña: ");
                intento = Console.ReadLine();

                if (intento == g)
                {
                    Console.WriteLine("Contraseña correcta. Acceso concedido.");
                    return;
                }
                else
                {
                    intentos--;
                    if (intentos > 0)
                    {
                        Console.WriteLine($"Contraseña incorrecta. Le quedan {intentos} intentos.");
                    }
                }
            }
            Console.WriteLine("Acesso denegado. Cerrando progama!");

        }

    }
}
