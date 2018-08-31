using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrispiPractice
{
    class Articulo
    {
        public string IdProducto { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }

        public Articulo() { }
        public Articulo(string idProducto, float precio, int stock)
        {
            IdProducto = idProducto;
            Precio = precio;
            Stock = stock;
        }

        public void DescontarStock(int cant)
        {
            Stock -= cant;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("El articulo {0} tiene un stock de: {1}", IdProducto, Stock);
        }
    }
}
