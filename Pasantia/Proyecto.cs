using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasantia
{
    class Proyecto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Objetivo { get; set; }
        public string HorasEstimadas { get; set; }
        public string TipoProyecto { get; set; }
        public bool Asignado { get; set; }
        public Empresa RefEmpresa { get; set; }

        public Proyecto() { }
        public Proyecto(string codigo, string nombre, string objetivo, string horasEstimadas, string tipoProyecto)
        {
            Codigo = codigo;
            Nombre = nombre;
            Objetivo = objetivo;
            HorasEstimadas = horasEstimadas;
            TipoProyecto = tipoProyecto;
            Asignado = false;
        }

        public void SeleccionarEmpresa(List<Empresa> empresas)
        {
            int i = 0;

            foreach (var e in empresas) {
                i++;
                Console.Write(i + ">");
                e.MostrarEmpresa();
            }

            Console.WriteLine("Seleccione Empresa");
            i = int.Parse(Console.ReadLine());

            RefEmpresa = empresas[i - 1];
        }

        public void MostrarProyecto()
        {
            Console.WriteLine("el proyecto {0} tiene {1} horas y pertenece a la empresa {2} ", Nombre, HorasEstimadas, RefEmpresa.Nombre);
        }
    }
}
