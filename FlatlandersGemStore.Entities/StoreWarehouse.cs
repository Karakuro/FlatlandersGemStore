using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatlandersGemStore.Entities
{
    public static class StoreWarehouse
    {


        public static List<Entities.Gem> Gems { get; set; }

        static StoreWarehouse()
        {
            Gems = new List<Entities.Gem>();

            Gems.Add(new Entities.Gem
            {
                Colour = "#000",
                Description = "Zircon is our most coveted and sought after gem. You will pay much to be the proud owner of this gorgeous and high shine gem.",
                Name = "Zircon",
                Rarity = 2,
                Price = 11000,
                Reviews = null
            });

            Gems.Add(new Entities.Gem
            {
                Colour = "#eee",
                Description = "Origin of the Bloodstone is unknown, hence its low value. It has a very high shine and 12 sides, however.",
                Name = "Bloodstone",
                Rarity = 6,
                Price = 23.65M,
                Reviews = null
            });
            Gems.Add(new Entities.Gem
            {
                Colour = "#CCC",
                Description = "Some gems have hidden qualities beyond their luster, beyond their shine... Azurite is one of those gems.",
                Name = "Azurite",
                Rarity = 7,
                Price = 123,
                Reviews = null

        });            
        }


}

}
