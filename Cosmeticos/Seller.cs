using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmeticos
{
    class Seller
    {
        private Zone[] zones;
        private float totalCollected;

        public Seller()
        {
            zones = new Zone[4];
            totalCollected = 0;
        }

        // Retorna el vector de zonas.
        public Zone[] GetZones() { return zones; }

        // Retorna lo recaudado por el vendedor.
        public float GetTotalCollected() { return totalCollected; }

        // Valida que la zona que se ingreso realmente exista
        private int ValidateZone(char id)
        {
            for (int i = 0; i < zones.Length; i++)
            {
                if (zones[i].id == id)
                    return i;
            }

            return -1;
        }

        // Agrega al vector de zona lo que se vendió.
        public void AddSale(char id, float value)
        {
            int i = ValidateZone(id);

            if (i != -1)
                zones[i].collection += value;
            else
                Console.WriteLine("NO EXISTE LA ZONA");
        }

        // Agrega todo lo recaudado en todas las zonas.
        public void TotalCollected()
        {
            foreach (var z in zones)
                totalCollected += z.collection;
        } 

        // Inicializa el vector de zonas.
        public void InitializeZones()
        {
            var id = new char[4] { 'A', 'B', 'C', 'D' };

            for (int i = 0; i < zones.Length; i++)
                zones[i] = new Zone(id[i]);
        }
    }
}
