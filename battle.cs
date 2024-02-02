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
}
