using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S13_SEMANA_C_
{
    internal class Estudiantes
    {
        string[] nombres = new string[0];
        byte[] edades = new byte[0];
        int pos = 0;

        public void insertar()
        {
            string seguir;

            while (true)
            {
                Array.Resize(ref nombres, nombres.Length + 1);
                Array.Resize(ref edades, edades.Length + 1);

                Console.Write("\nIngrese nombre: ");
                nombres[pos] = Console.ReadLine();
                Console.Write("\nIngrese edad: ");
                edades[pos] = byte.Parse(Console.ReadLine());
                pos++;

                while (true)
                {
                    Console.Write("¿\nDesea seguir registrando? (S/N): ");
                    seguir = Console.ReadLine();
                    if (seguir == "s" || seguir == "n") break;
                    else Console.WriteLine("\nOpcion no valida");
                }
                if (seguir == "n") break;
            }
        }




        public void mostrar()
        {
            Console.WriteLine("POS\tNOMBRE\t\tEDAD");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"{i}\t{nombres[i]}\t\t{edades[i]}");
            }
        }

        public int buscar(string nom)
        {
            Console.WriteLine("Ingrese el nombre a buscar: ");
            string buscar = Console.ReadLine();

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nom == nombres[i])
                    return i; // Retorna el índice si se encuentra el nombre
            }
            return -1; // Retorna -1 si no se encuentra el nombre
        }

        public void modificar()
        {
            Console.WriteLine("\nIngrese el nombre a modificar: ");
            string nom = Console.ReadLine();

            int indice = buscar(nom);

            if (indice != -1)
            {
              Console.WriteLine("\nIngrese el nuevo nombre: ");
            }
        }
        public void eliminar()

        {
            Console.Write("\nIngrese el nombre eliminar: ");
            string nom = Console.ReadLine() ;

            int indice = buscar(nom);

            if (indice != 1)
            {
                for (int i =indice; i < nombres.Length; i++) 
                {
                    nombres[i] = nombres[i + 1];
                    edades[i] = edades[i + 1];
            
                }

                Array.Resize(ref nombres, nombres.Length - 1);
                Array.Resize(ref edades, edades.Length - 1);

            }   

        }
    }
}
