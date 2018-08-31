using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasantia
{
    class Alumno
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public float Nota { get; set; }
        public bool Asignado { get; set; }
        public List<Proyecto> Proyectos { get; set; } = new List<Proyecto>();

        public Alumno() { }
        public Alumno(string dni, string nombre, float nota)
        {
            Dni = dni;
            Nombre = nombre;
            Nota = nota;
            Asignado = false;
        }

        public void SeleccionarProyectos(List<Proyecto> proyectos)
        {
            int i = 0;

            foreach (var p in proyectos) {
                i++;
                Console.Write(i + ">");
                p.MostrarProyecto();
            }

            Console.WriteLine("Seleccione proyecto");
            i = int.Parse(Console.ReadLine());

            Proyectos.Add(proyectos[i - 1]);
        }

        public void MostrarAlumno()
        {
            Console.WriteLine("El alumno {0} con dni {1} tiene una nota de {2}", Nombre, Dni, Nota);
        }
    }
}
