using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Carrera
    {
        public List<Equipo> Equipos { get; private set; } = new List<Equipo>();
        public List<Corredor> Corredores { get; private set; } = new List<Corredor>();
        private readonly Etapa[] etapas;

        struct Etapa
        {
            public DateTime FechaEtapa { get; set; }
            public string KmEtapa { get; set; }
        }

        public Carrera()
        {
            etapas = new Etapa[2];
            CrearEtapa();
        }

        private void CrearEtapa()
        {
            for (int i = 0; i < etapas.Length; i++)
            {
                Console.WriteLine("Ingrese fecha etapa formato DD/MM/AAAA");
                etapas[i].FechaEtapa = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese KM de la etapa");
                etapas[i].KmEtapa = Console.ReadLine();
            }
        }

        public void AñadirCorredor(Corredor corredor)
        {
            Corredores.Add(corredor);
        }

        public void AñadirEquipo(Equipo equipo)
        {
            Equipos.Add(equipo);
        }

        public void IniciarCarrera()
        {
            var aux = new Corredor();

            foreach (var e in etapas) {
                Console.WriteLine("Esta es la etapa {0} con un kilometraje de {1}", e.FechaEtapa.ToShortDateString(), e.KmEtapa);

                foreach (var c in Corredores) {
                    c.LimpiarTiempo();
                    Console.WriteLine("Ingrese tiempo {0} ", c.Nombre);
                    c.TiempoCarrera = float.Parse(Console.ReadLine());

                    c.CalcularPromedio(float.Parse(e.KmEtapa));
                }

                aux.OrdenarPorTiempo(Corredores);

                foreach (var eq in Equipos) {
                    float tiempo = 0;
                    int cant = 0;

                    foreach (var c in Corredores) {
                        if (eq.Nombre == c.RefEquipo.Nombre) {
                            tiempo += c.TiempoCarrera;
                            cant++;
                        }
                    }

                    eq.CalcularTiempo(tiempo, cant);
                }

                MostrarDatos();
            }
        }

        private void MostrarDatos()
        {
            Console.WriteLine("El ganador de la etapa fue: ");
            Corredores[0].MostrarCorredor();
            Console.WriteLine("Mejor Promedio {0}\nPeor Promedio {1}", Corredores[0].Nombre, Corredores[Corredores.Count - 1].Nombre);
            Console.WriteLine("El tiempo de los equipos esta carrera fue");
            foreach (var e in Equipos)
                Console.WriteLine(e.TiempoEquipo);

        }
    }
}
