using System.Collections.Generic;
using SpaceGame.Planets;

namespace SpaceGame
{
    public class StarGaze : IPlanet
    {
        public PlanetName Name { get; set; }
        public Coordinate Coordinates { get; set; }
        public List<Item> ItemList { get; set; }

        public List<Item> GenerateItems()
        {
            throw new System.NotImplementedException();
        }
    }
}