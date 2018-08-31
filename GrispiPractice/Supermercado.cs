using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrispiPractice
{
    class Supermercado
    {
        Caja[] cajas;
        Articulo[] articulos;

        public Supermercado() { }
        public Supermercado(Caja[] cajas, Articulo[] articulos)
        {
            this.cajas = cajas;
            this.articulos = articulos;
        }

        public void ComienzoDia()
        {
            string idArt, idCaja;
            int cant;

            Console.WriteLine("Ingrese código de caja:");
            idCaja = Console.ReadLine();

            foreach (var c in cajas) {
                if(c.IdCaja == idCaja) {
                    Console.WriteLine("Ingrese código de artículo:");
                    idArt = Console.ReadLine();

                    foreach (var a in articulos) {
                        if(a.IdProducto == idArt) {
                            Console.WriteLine("Ingrese cantidad:");
                            cant = int.Parse(Console.ReadLine());

                            c.AgregarUnidadesVendidas(idArt, cant);
                        }
                    }
                }
            }
        }

        public void FinDia()
        {
            foreach (var c in cajas)
                c.CalcularTotalRecaudado(articulos);

            foreach (var a in articulos) {
                foreach (var c in cajas) {
                    if (c.UnidadesVendidas.ContainsKey(a.IdProducto))
                        a.DescontarStock(c.UnidadesVendidas[a.IdProducto]);
                }
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Datos cajas");
            foreach (var c in cajas)
                c.MostrarVentaPorCaja();

            Console.WriteLine("Datos articulos");
            foreach (var a in articulos)
                a.MostrarDatos();
        }
    }
}
