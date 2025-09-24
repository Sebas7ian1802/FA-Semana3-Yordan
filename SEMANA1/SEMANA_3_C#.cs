using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_3_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer4();
            Console.ReadKey(); //detenimiento de consola
        }
        

        static void ejer1()
        {
            //1.Desarrollar un programa que solicite tu nombre y carrera y luego imprima “<Tu
            //nombre >, Bienvenido al curso de Fundamentos de Algoritmos de la carrera<Tu
            //carrera>”.

            string nombre, carrera;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido al curso " +
                $"de Fundamentos de Algoritmo de la carrera {carrera}");
        }

        static void ejer2()
        {
            //2.Desarrollar un algoritmo que te permita imprimir tu nombre entre comillas
            //dobles.

                        Console.WriteLine("\"Yordan\"");

        }

        static void ejer3()
        {
            //3.Solicitar al usuario dos números enteros y realizar las siguientes operaciones:
            //• Suma.
            //• Resta.
            //• Multiplicación.
            //• División.

            Console.Write("Ingrese numero 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            double divi = (double)num1 / (double)num2;

            Console.WriteLine("Suma: " + (num1 + num2));
            Console.WriteLine("Resta: " + (num1 - num2));
            Console.WriteLine("Multiplicación: " + (num1 * num2));
            Console.WriteLine("Division: " + divi);

        }

        static void ejer4()
        {
            //4.Solicitar al usuario un número decimal(ej. 12.75) y calcular:
            //• Su raíz cuadrada.
            //• El valor redondeado sin decimales.
            //• El resultado de elevar el número al cubo.
            //• Su raíz cubica.

            Console.WriteLine("Ingrese un numero decimal: ");
            double num = double.Parse(Console.ReadLine());

            //librerías 
            double raíz = Math.Sqrt(num); // raíz cuadrada
            double redo = Math.Round(num,2); // redondear
            double cubo = Math.Pow(num,3); // elevar al cubo
            double cubica = Math.Pow(num,1/3d); // raíz cubica


            Console.WriteLine("\nRaíz cuadrada: " + raíz);
            Console.WriteLine("\nRedondeado: " + redo);
            Console.WriteLine("\nElevado a 3: " + cubo);
            Console.WriteLine("\nRaíz cubica: " + cubica);



        }

        static void ejer5()
        {

            //5.Solicitar al usuario que ingrese un número en formato de texto(string) y
            //convertirlo a:
            //• Entero y mostrar su resto al dividir entre 2.
            //• Decimal y dividirlo entre 3.

            Console.Write("Ingrese un numero: ");
            string num = Console.ReadLine();

            int entero = int.Parse(num);
            double deci = double.Parse(num);

            Console.WriteLine("Resto: " + (entero % 2));
            Console.WriteLine("Decimal: " + (deci / 3));
        }
        static void ejer6()
        {
            //Pedir al usuario una cantidad de segundos y convertirla a:
            //• Horas
            //• Minutos
            //• Segundos restantes
        }
    }
}
