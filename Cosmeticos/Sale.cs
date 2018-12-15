using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmeticos
{
    class Sale
    {
        private Zone[] zones;
        private Seller[] sellers;

        public Sale()
        {
            zones = new Zone[4];
            sellers = new Seller[8];
        }

        // Inicializa el vector de zonas.
        public void InitializeZones()
        {
            var id = new char[4] { 'A', 'B', 'C', 'D' };

            for (int i = 0; i < zones.Length; i++)
                zones[i] = new Zone(id[i]);
        }

        // Inicializa el vector de vendedores.
        public void InitializeSellers()
        {
            for (int i = 0; i < sellers.Length; i++)
            {
                sellers[i] = new Seller();
                sellers[i].InitializeZones();
            }
        }

        // Añade la venta de los vendedores.
        public void AddSalesOfSellers()
        {
            char c = ' ';
            float value = 0;

            foreach (var s in sellers) {
                do {
                    Console.Write("Ingrese la zona en la que vendió: ");
                    c = char.Parse(Console.ReadLine());
                    c = char.ToUpper(c);

                    Console.Write("Ingrese el valor de lo que vendió: ");
                    value = float.Parse(Console.ReadLine());

                    s.AddSale(c, value);

                    Console.WriteLine("Desea continuar? S/N");
                    c = char.Parse(Console.ReadLine());
                    c = char.ToUpper(c);
                } while (c != 'N');
            }
        }

        // Calcula el total recaudado de todos los vendedores.
        public void CalculateTotalCollectedSellers()
        {
            foreach (var s in sellers)
                s.TotalCollected();
        }

        // Obtiene el total por zonas.
        public void TotalPerZones()
        {
            foreach (var s in sellers) {
                for (int i = 0; i < s.GetZones().Length; i++)
                    zones[i].collection += s.GetZones()[i].collection;
            }
        }

        // Obtiene el indx del vendedor con mayor recaudación.
        private int GetSellerWhitHighestSales()
        {
            int j = 0;
            float aux = 0;

            for (int i = 0; i < sellers.Length; i++)
            {
                if (i == 0)
                    aux = sellers[i].GetTotalCollected();

                if(sellers[i].GetTotalCollected() > aux) {
                    aux = sellers[i].GetTotalCollected();
                    j = i;
                }
            }

            return j;
        }

       // Obtiene el porcentaje del vendedor con mayor recaudación y lo muestra por pantalla.
        public void GetPercentBiggerSeller()
        {
            int i = GetSellerWhitHighestSales();

            Console.WriteLine("El porcentaje que recibe el vendedor de mayor recaudación es: " + (30 * sellers[i].GetTotalCollected()) / 100);
        }

        // Obtiene el indx de un vendedor aleatorio.
        private int RandomSeller()
        {
            var rnd = new Random();
            return rnd.Next(8);
        }

        // De ese vendedor aleatorio obtiene cual fue la zona en la que más vendió.
        public void GetZoneWithBiggerSales()
        {
            int j = RandomSeller();
            int z = 0;
            float aux = 0;

            for (int i = 0; i < sellers[j].GetZones().Length; i++)
            {
                if (i == 0)
                    aux = sellers[j].GetZones()[i].collection;

                if (sellers[j].GetZones()[i].collection > aux) {
                    aux = sellers[j].GetZones()[i].collection;
                    z = i;
                }
            }

            Console.WriteLine("La zona con mayor venta fue: " + sellers[j].GetZones()[z].id + " con una recaudación de: " + sellers[j].GetZones()[z].collection);
        }

        public void AverageSales()
        {
            float avrg = 0;

            foreach (var s in sellers)
                avrg += s.GetTotalCollected();

            Console.WriteLine("El promedio de las ventas de todos los vendedores es de: " + avrg / sellers.Length);
        }

    }
}
