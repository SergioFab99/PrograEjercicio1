using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograEjercicio1
{
    class Jugador : Personaje
    {
        public Jugador(string nombre, int salud) : base(nombre, salud)
        {
        }

        public void Atacar(Personaje objetivo)
        {
            int daño = 20;
            objetivo.Salud -= daño;
            Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre} causando {daño} de daño.");
        }

        public void UsarObjeto(Objeto objeto)
        {
            Console.WriteLine($"{Nombre} usa {objeto.Nombre}");
        }
    }
}