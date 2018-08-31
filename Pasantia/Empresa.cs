using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasantia
{
    class Empresa
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Cuit { get; set; }

        public Empresa() { }
        public Empresa(string nombre, string direccion, string cuit)
        {
            Nombre = nombre;
            Direccion = direccion;
            Cuit = cuit;
        }

        public void MostrarEmpresa()
        {
            Console.WriteLine("La empresa {0} con cuit {1} está en {2} ", Nombre, Cuit, Direccion);
        }
    }
}
