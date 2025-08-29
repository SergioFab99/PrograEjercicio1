using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograEjercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador("Héroe", 100);
            Enemigo enemigo = new Enemigo("Dragón", 80);
            Objeto objeto = new Objeto("Espada de Fuego");

            Console.WriteLine("AVENTURA DE TEXTOS");
            Console.WriteLine("Bienvenido al juego textual");
            Console.WriteLine();

            jugador.MostrarEstado();
            enemigo.MostrarEstado();
            objeto.MostrarInfo();

            Console.WriteLine("\n¿Qué deseas hacer?");
            Console.WriteLine("1. Atacar al dragón canelonni");
            Console.WriteLine("2. Usar el objeto");
            Console.WriteLine("3. Huir como cobarde");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    jugador.Atacar(enemigo);
                    break;
                case "2":
                    jugador.UsarObjeto(objeto);
                    break;
                case "3":
                    Console.WriteLine("Has huido como un vil marica");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            Console.WriteLine("\nFin del juego.");
            Console.ReadKey();
        }
    }
}