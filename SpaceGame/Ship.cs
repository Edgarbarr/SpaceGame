using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceGame
{
    public enum ShipUpgrade { NoobShip, Stargazer, Velociraptor };
    
    public class Ship
    {
        public int CargoCapacity { get; set; }
        public int CurrentWarpSpeed { get; set; }
        public Planet CurrentPlanet { get; set; }
        public ShipUpgrade Upgrade { get; set; }
        public int MaxWarpSpeed { get; set; }
        public int FuelUnits { get; set; }
        public double MaxLightYears { get; set; }

        public Ship(ShipUpgrade upgrade)
        {
            CargoCapacity = 10;
            CurrentWarpSpeed = 1;
            CurrentPlanet = new Planet(PlanetName.Earth);
            Upgrade = upgrade;
            MaxWarpSpeed = CalculateMaxWarpSpeed();
            FuelUnits = 10;
            MaxLightYears = CalculateMaxLightYears();
        }
        //
        // C# Naming Conventions
        // public variables == camelCase
        // private variables == _example
        // Enums, Classes, Properties, Methods = PascalCase

        public int CalculateMaxWarpSpeed()
        {
            switch (Upgrade)
            {
                case ShipUpgrade.NoobShip:
                    return 1;
                case ShipUpgrade.Stargazer:
                    return 2;
                case ShipUpgrade.Velociraptor:
                    return 7;
                default:
                    return 0;
            }
        }
        
        public double CalculateMaxLightYears()
        {
            return FuelUnits * 10;
        }

        public void SetWarpSpeed(int warpSpeed)
        {
            Console.WriteLine("At what warp speed would you like to travel?");
            
        }
        
        public void FlyTo(Planet planet)
        {
            CurrentPlanet = planet;
            Console.WriteLine("Traveling...");

            // Uncomment the line below to delay the program for 3000 milliseconds (3 seconds)
            // which simulates the ship is traveling in real time; Make sure you study Thread.Sleep before you use it
            //Thread.Sleep(3000);
            Console.WriteLine($"You have now arrived at: {CurrentPlanet.Name}");
        }
    }
}
