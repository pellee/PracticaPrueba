using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Equipo
    {
        public string IdEquipo { get; set; }
        public string Nombre { get; set; }
        public float TiempoEquipo { get; set; }

        public Equipo() { }
        public Equipo(string idEquipo, string nombre)
        {
            IdEquipo = idEquipo;
            Nombre = nombre;
            TiempoEquipo = 0;
        }

        public void CalcularTiempo(float tiempo, int cant)
        {
            TiempoEquipo = tiempo/cant;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("El equipo {0} tiene un tiempo de {1}", Nombre, TiempoEquipo);
        }
    }
}
