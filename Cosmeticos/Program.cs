using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmeticos
{
    struct Zone
    {
        public char id;
        public float collection;

        public Zone(char id)
        {
            this.id = id;
            collection = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sale = new Sale();

            sale.InitializeZones();
            sale.InitializeSellers();

            sale.AddSalesOfSellers();
            sale.CalculateTotalCollectedSellers();

            sale.TotalPerZones();
            sale.GetPercentBiggerSeller();
            sale.GetZoneWithBiggerSales();
            sale.AverageSales();

        }
    }
}
