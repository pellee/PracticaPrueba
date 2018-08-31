 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Program
    {
        static Corredor CrearCorredor(int i, List<Equipo> equipos)
        {
            int j = 0;
            foreach (var e in equipos) {
                j++;
                Console.WriteLine(j+">"+"  "+e.Nombre);
            }

            Console.WriteLine("Seleccione equipo: ");
            j = Int32.Parse(Console.ReadLine());

            return new Corredor(i.ToString(), "carlos " + i, equipos[j-1]);
        }

        static Equipo CrearEquipo(int i)
        {
            return new Equipo(i.ToString(), "equipo " + i);
        }

        static void Main(string[] args)
        {
            var carrera = new Carrera();

            for (int i = 0; i < 2; i++)
                carrera.AñadirEquipo(CrearEquipo(i));

            for (int i = 0; i < 4; i++)
                carrera.AñadirCorredor(CrearCorredor(i, carrera.Equipos));

            carrera.IniciarCarrera();
        }
    }
}
