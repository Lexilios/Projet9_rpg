class program
{
    static void Main(string[] args)
    {
        FireHero LionHeart = new FireHero("LionHeart", 5, 15, 20);
        WaterHero Lancelot = new WaterHero("Lancelot", 6, 10, 20);
        EarthHero Alexender = new EarthHero("Alexender", 3, 20, 20);

        Bandit Keith = new Bandit("Keith", 2, 8);
        Bandit Ben = new Bandit("Bandit Ben", 2, 8);

        FireEnemy FireGolem = new FireEnemy("Fire Golem", 3, 12);


        FireEnemy FireDragon = new FireEnemy("Fire Dragon", 5, 20);
    }

}