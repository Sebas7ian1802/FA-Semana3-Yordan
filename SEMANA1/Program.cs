using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer4();
            Console.ReadKey(); //detenimineto de consola
        }
        

        static void ejer1()
        {
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
            Console.WriteLine("\"Yordan\"");
        }

        static void ejer3()
        {
            Console.Write("Ingrese numero 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            double divi = (double)num1 / (double)num2;

            Console.WriteLine("Suma: " + (num1 + num2));
            Console.WriteLine("Resta: " + (num1 - num2));
            Console.WriteLine("Multiplicacion: " + (num1 * num2));
            Console.WriteLine("Division: " + divi);

        }

        static void ejer4()
        {
            Console.WriteLine("Ingrese un numero decimal: ");
            double num = double.Parse(Console.ReadLine());

            //librerias 
            double raiz = Math.Sqrt(num); // raiz cuadrada
            double redo = Math.Round(num,2); // redondear
            double cubo = Math.Pow(num,3); // elevar al cubo
            double cubica = Math.Pow(num,1/3d); // raiz cubica


            Console.WriteLine("\nRaiz cuadrada: " + raiz);
            Console.WriteLine("\nRedondeado: " + redo);
            Console.WriteLine("\nElevado a 3: " + cubo);
            Console.WriteLine("\nRaiz cubica: " + cubica);



        }

        static void ejer5()
        {

        }

        static void ejer6()
        {

        }
    }
}
