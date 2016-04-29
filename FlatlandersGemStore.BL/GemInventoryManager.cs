using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatlandersGemStore.Entities;
using FlatlandersGemStore.Entities.Entities;


namespace FlatlandersGemStore.BL
{
    public class GemInventoryManager
    {
        private List<Gem> Inventory;
        public GemInventoryManager()
        {
            Inventory = new List<Gem>();
            Inventory.AddRange(StoreWarehouse.Gems);
        }

        public void StoreNewGems()
        {
            Inventory.AddRange(StoreWarehouse.Gems);
        }

        public Gem GetSingleGem(string name)
        {
            return Inventory.FirstOrDefault(x => x.Name == name);
        }

        public bool SellSingleGem(string name)
        {
            return Inventory.Remove(GetSingleGem(name));
        }

        public List<Gem> GetAllInventory()
        {
            return Inventory;
        }
    }
}
