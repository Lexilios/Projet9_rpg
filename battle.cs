class Battle
{
    public static void IsHeroDead(Hero hero)
    {
        if (hero.health <= 0)
        {
            Console.Clear();
            Console.WriteLine("==============");
            Console.WriteLine(" | YOU ARE DEAD |");
            Console.WriteLine("==============");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
    public static void Stats (Person person1, Person person2) 
    {
        person1.PrintStats();
        Console.WriteLine();
        person2.PrintStats();
        Console.WriteLine();
    }

    public static void Duel(Enemy enemy, Hero hero, Map firstmap)
    {
        while (enemy.health > 0 && hero.health > 0)
        {
            Stats(hero, enemy);
            hero.YourTurn(hero.Choice(), enemy);

            if (enemy.health > 0)
            {
                if ((Bandit)enemy != null)
                {
                    Bandit bandit = (Bandit)enemy;
                    bandit.BanditTurn(enemy.EChoice(), hero);

                }

                if ((Dragon)enemy != null)
                {
                    Dragon dragon = (Dragon)enemy;
                    dragon.DragonTurn(enemy.EChoice(), hero);
                }

                if ((Golem)enemy != null)
                {
                    Golem golem = (Golem)enemy;
                    golem.GolemTurn(enemy.EChoice(), hero);
                }
            }
        }

    }
}
