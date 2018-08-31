using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasantia
{
    class Pasantia
    {
        public List<Empresa> Empresas { get; set; }
        public List<Proyecto> Proyectos { get; set; }
        public List<Alumno> Alumnos { get; set; }

        public Pasantia()
        {
            Empresas = new List<Empresa>();
            Proyectos = new List<Proyecto>();
            Alumnos = new List<Alumno>();
        }

        public void AgregarEmpresa(Empresa empresa)
        {
            Empresas.Add(empresa);
        }

        public void AgregarProyecto(Proyecto proyecto)
        {
            Proyectos.Add(proyecto);
        }

        public void AgregarAlumno(Alumno alumno)
        {
            Alumnos.Add(alumno);
        }

        public void ListarAsignados()
        {
            Console.WriteLine("ASIGNADOS");

            foreach (var a in Alumnos) {
                if (a.Asignado) {
                    a.MostrarAlumno();
                    foreach (var p in a.Proyectos) {
                        if (p.Asignado)
                            p.MostrarProyecto();
                    }
                }
            }
        }

        public void ListarNoAsignados()
        {
            Console.WriteLine("NO ASIGNADOS");

            foreach (var a in Alumnos) {
                if (!a.Asignado)
                    a.MostrarAlumno();
            }
        }

        public void OrdenarAlumnos()
        {
            for (int i = 0; i < Alumnos.Count-1; i++)
            {
                for (int j = i+1; j < Alumnos.Count; j++)
                {
                    if(Alumnos[i].Nota < Alumnos[j].Nota) {
                        var aux = Alumnos[i];
                        Alumnos[i] = Alumnos[j];
                        Alumnos[j] = aux;
                    }
                }
            }
        }

        public void AsignarAlumnos()
        {
            foreach (var a in Alumnos) {
                foreach (var p in Proyectos) {
                    if(!a.Asignado && !p.Asignado) {
                        int i = a.Proyectos.IndexOf(p);
                        if(i != -1) {
                            a.Proyectos[i].Asignado = true;
                            a.Asignado = true;
                            p.Asignado = true;
                        }
                    }
                }
            }
        }
    }
}
