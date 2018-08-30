using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame.Planets
{
    public class AlphaCentauri : IPlanet
    {
        public PlanetName Name { get; set; }
        public Coordinate Coordinates { get; set; }
        public List<Item> ItemList { get; set; }

        public AlphaCentauri()
        {
            Name = PlanetName.Earth;
            Coordinates = new Coordinate(0, 0);
            ItemList = GenerateItems();
        }

        public List<Item> GenerateItems()
        {
            return new List<Item>
            {
                new Item("Orbs", 150, 1, 150),
                new Item("Plasma", 300, 1, 300)
            };
        }
    }
}
