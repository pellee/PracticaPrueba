using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrispiPractice
{
    class Caja
    {
        public string IdCaja { get; set; }
        public Dictionary<string, int> UnidadesVendidas { get; set; }
        private float TotalRecaudado { get; set; }

        public Caja() { }
        public Caja(string idCaja)
        {
            IdCaja = idCaja;
            UnidadesVendidas = new Dictionary<string, int>();
        }

        public void AgregarUnidadesVendidas(string id, int cant)
        {
            if (UnidadesVendidas.ContainsKey(id))
                UnidadesVendidas[id] += cant;
            else
                UnidadesVendidas.Add(id, cant);
        }

        public void CalcularTotalRecaudado(Articulo[] articulos)
        {
            foreach (var a in articulos) {
                if (UnidadesVendidas.ContainsKey(a.IdProducto))
                    TotalRecaudado += (UnidadesVendidas[a.IdProducto] * a.Precio);
            }
        }

        public void MostrarVentaPorCaja()
        {
            Console.WriteLine("La caja {0} recaudo {1}", IdCaja, TotalRecaudado);
            Console.WriteLine("Y vendió estos artículos");

            foreach (var uv in UnidadesVendidas)
                Console.WriteLine("cod: {0} cant: {1}", uv.Key, uv.Value);
        }
    }
}
