using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA7_C_
{
    internal class Program
    {
        static void Main(string[] args)

        {
            ejer3();
            Console.ReadKey(); //detenimiento de consola
        }

        static void ejer1()
        {


            int num, po = 0, ne = 0;

            do
            {
                Console.Write("Ingrese un número entero (negativo para salir): ");
                num = int.Parse(Console.ReadLine());

                if (num < 0) continue;
                if (num % 2 == 0) po++;
                else ne++;

            } while (num > 0);

            Console.WriteLine("\nCantidad de pares: " + po);
            Console.WriteLine("Cantidad impares; " + ne);
            Console.ReadKey();

        }

        static void ejer2()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("* BIENVENIDOS AL JUEGO ADIVINAD EL NUMERO *");
            Console.WriteLine("*                                         *");
            Console.WriteLine("*Instrucciones                            *");
            Console.WriteLine("*1. Tienes 3 intentos                     *");
            Console.WriteLine("*2. Cada fallo ud. tendra una pista       *");
            Console.WriteLine("*******************************************");

            int intentos = 3;
            Random rnd = new Random();
            int secreto = rnd.Next(1, 21);

            do
            {

                Console.Write("Ingrese el numero a adivinar: ");
                int num = int.Parse(Console.ReadLine());

                if (num == secreto)
                {
                    Console.WriteLine("\nFelicidades, has adivinado el numero!");
                    return;
                }
                else
                {
                    intentos--;
                    if (num < secreto)
                        Console.WriteLine("Pista: El numero es mayor");
                    else
                        Console.WriteLine("Pista: El numero es menor\n");
                }
            }while (intentos > 0);
            Console.WriteLine($"\nNo lograste adivinar el numero {secreto}!");
        }

        static void ejer3()
        {
            string opcion;
            int suma = 0;
            do
            {
                Console.Clear(); //Limpiador
                Console.Write("Ingrese un numero positivo: ");
                int num = int.Parse(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                    suma += i;

                Console.WriteLine("\nSuma: " + suma);

                Console.Write("¿Desea continuar (S/N): ");
                opcion = Console.ReadLine();

                

            } while (opcion != "N");
            Console.WriteLine("\nPrograma finalizado");
        }
    }
}
