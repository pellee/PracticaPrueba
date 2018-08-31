using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrispiPractice
{
    class Program
    {
        static Caja CrearCaja(int i)
        {
            return new Caja(i++.ToString());
        }

        static Articulo CrearArticulo(int i)
        {
            return new Articulo(i++.ToString(), (i++) * 10, (i++) * 100);
        }

        static void Main(string[] args)
        {
            char opc;
            var cajas = new Caja[3];
            var articulos = new Articulo[3];

            for (int i = 0; i < cajas.Length; i++)
                cajas[i] = CrearCaja(i);

            for (int i = 0; i < articulos.Length; i++)
                articulos[i] = CrearArticulo(i);

            var super = new Supermercado(cajas, articulos);

            do {
                super.ComienzoDia();

                Console.WriteLine("Desea continuar? S/N");
                opc = char.Parse(Console.ReadLine());
                opc = Char.ToUpper(opc);
            } while (opc != 'N');

            super.FinDia();
            super.MostrarDatos();
        }
    }
}
