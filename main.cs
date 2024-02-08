using System;

public class Program
{
    static void Main(string[] args)
    {
       

        Map firstmap = new Map();
        firstmap.map();

        ElementHero LionHeart = new ElementHero("LionHeart", 5, 15, 20, ElementEnum.Fire);
        ElementHero Lancelot = new ElementHero("Lancelot", 6, 10, 20, ElementEnum.Water);
        ElementHero Alexender = new ElementHero("Alexender", 3, 20, 20, ElementEnum.Earth);

        Bandit Keith = new Bandit("Bandit Keith", 2, 8, ElementEnum.NonElement);
        Bandit Ben = new Bandit("Bandit Ben", 2, 8, ElementEnum.NonElement);

        Golem FireGolem = new Golem("Fire Golem", 3, 12, ElementEnum.Fire);
        Golem WaterGolem = new Golem("Water Golem", 3, 12, ElementEnum.Water);
        Golem EarthGolem = new Golem("Earth Golem", 3, 12, ElementEnum.Earth);


        Dragon FireDragon = new Dragon("Fire Dragon", 5, 20,10, ElementEnum.Fire);
        Dragon WaterDragon = new Dragon("Water Dragon", 5, 20,10, ElementEnum.Water);
        Dragon EarthDragon = new Dragon("Earth Dragon", 5, 20,10, ElementEnum.Earth);
    }

}
