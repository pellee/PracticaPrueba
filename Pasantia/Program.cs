using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasantia
{
    class Program
    {
        static Alumno CrearAlumno(int i, List<Proyecto> proyectos)
        {
            var aux = new Alumno(((i++) * 100).ToString(), "joquin " + i, i * 2);
            char opc;

            do {
                aux.SeleccionarProyectos(proyectos);

                Console.WriteLine("Desea Continuar? S/N");
                opc = char.Parse(Console.ReadLine());
                opc = char.ToUpper(opc);
            } while (opc != 'N');

            return aux;
        }

        static Empresa CrearEmpresa(int i)
        {
            return new Empresa("empresa " + i++, "direccion " + i, ((i++) * 100).ToString());
        }

        static Proyecto CrearProyecto(int i, List<Empresa> empresas)
        {
            var aux = new Proyecto(((i++) * 100).ToString(), "proyecto " + i, "objetivo", ((i++) * 10).ToString(), "tipoPro");

            aux.SeleccionarEmpresa(empresas);

            return aux;
        }

        static void Main(string[] args)
        {
            var pasantia = new Pasantia();

            for (int i = 0; i < 2; i++)
                pasantia.AgregarEmpresa(CrearEmpresa(i));

            for (int i = 0; i < 3; i++)
                pasantia.AgregarProyecto(CrearProyecto(i, pasantia.Empresas));

            for (int i = 0; i < 5; i++)
                pasantia.AgregarAlumno(CrearAlumno(i, pasantia.Proyectos));

            pasantia.OrdenarAlumnos();
            pasantia.AsignarAlumnos();

            pasantia.ListarAsignados();
            pasantia.ListarNoAsignados();
        }
    }
}
