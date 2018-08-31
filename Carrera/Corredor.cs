using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Corredor
    {
        public string ID { get; private set; }
        public string Nombre { get; private set; }
        public float TiempoCarrera { get; set; }
        public float Prom { get; set; }
        public Equipo RefEquipo { get; private set; }

        public Corredor() { }
        public Corredor(string id, string nombre, Equipo equipo)
        {
            ID = id;
            Nombre = nombre;
            RefEquipo = equipo;
            TiempoCarrera = 0;
            Prom = 0;
        }

        public void LimpiarTiempo()
        {
            TiempoCarrera = 0;
        }

        public void CalcularPromedio(float km)
        {
            Prom = TiempoCarrera / km;
        }

        public void MostrarCorredor()
        {
            Console.WriteLine("El corredor {0} pertenece al equipo {1} con un tiempo {2}", Nombre, RefEquipo.Nombre, TiempoCarrera);
        }

        public void OrdenarPorTiempo(List<Corredor> corredores)
        {
            for (int i = 0; i < corredores.Count - 1; i++)
            {
                for (int j = i + 1; j < corredores.Count; j++)
                {
                    if(corredores[i].TiempoCarrera > corredores[j].TiempoCarrera) {
                        var aux = corredores[i];
                        corredores[i] = corredores[j];
                        corredores[j] = aux;
                    }
                }
            }
        }
    }
}
