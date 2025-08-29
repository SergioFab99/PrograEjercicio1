using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograEjercicio1
{
    class Enemigo : Personaje
    {
        public Enemigo(string nombre, int salud) : base(nombre, salud)
        {
        }

        public override void MostrarEstado()
        {
            Console.WriteLine($"El enemigo {Nombre} tiene {Salud} puntos de salud.");
        }
    }
}