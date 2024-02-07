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
    public static void WithBandit(NonElement bandit, ElementHero hero)
    {
        while (bandit.health > 0 && hero.health > 0) 
        {
            Stats(hero, bandit);
            hero.YourTurn(hero.Choice(), bandit);

            if (bandit.health > 0) 
            {

            }
        }
    }
}
