using SpaceGame;
using SpaceGame.Planets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

PlanetName Name { get; set; }
Coordinate Coordinates { get; set; }
List<Item> ItemsList { get; set; }

List<Item> GenerateItems();