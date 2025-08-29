using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograEjercicio1
{
    class Personaje
    {
        public string Nombre { get; set; }
        public int Salud { get; set; }

        public Personaje(string nombre, int salud)
        {
            Nombre = nombre;
            Salud = salud;
        }

        public virtual void MostrarEstado()
        {
            Console.WriteLine($"{Nombre} tiene {Salud} puntos de salud.");
        }
    }
}