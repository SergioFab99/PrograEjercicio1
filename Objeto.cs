using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograEjercicio1
{
    class Objeto
    {
        public string Nombre { get; set; }

        public Objeto(string nombre)
        {
            Nombre = nombre;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Objeto encontrado: {Nombre}");
        }
    }
}