class program
{
    static void Main(string[] args)
    {
        ElementHero LionHeart = new ElementHero("LionHeart", 5, 15, 20, ElementEnum.Fire);
        ElementHero Lancelot = new ElementHero("Lancelot", 6, 10, 20, ElementEnum.Water);
        ElementHero Alexender = new ElementHero("Alexender", 3, 20, 20, ElementEnum.Earth);

        NonElement Keith = new NonElement("Bandit Keith", 2, 8, ElementEnum.NonElement);
        NonElement Ben = new NonElement("Bandit Ben", 2, 8, ElementEnum.NonElement);

        ElementEnemy FireGolem = new ElementEnemy("Fire Golem", 3, 12, ElementEnum.Fire);
        ElementEnemy WaterGolem = new ElementEnemy("Water Golem", 3, 12, ElementEnum.Water);
        ElementEnemy EarthGolem = new ElementEnemy("Earth Golem", 3, 12, ElementEnum.Earth);


        ElementEnemy FireDragon = new ElementEnemy("Fire Dragon", 5, 20, ElementEnum.Fire);
        ElementEnemy WaterDragon = new ElementEnemy("Water Dragon", 5, 20, ElementEnum.Water);
        ElementEnemy EarthDragon = new ElementEnemy("Earth Dragon", 5, 20, ElementEnum.Earth);
    }

}