public class Hero : Person
{
    public int healLvl = 7, maxHealth = 15;

    public Hero(string _name, int _attack, int _health)
        : base(_name, _attack, _health)
    {
    }

    public void LevelUp()
    {
        Console.WriteLine("You leveled up !");
        Console.WriteLine("Attack +3");
        Console.WriteLine("Max health +10");
        Console.WriteLine("Heal +5");
        Console.ReadLine();
        Console.Clear();

        attack += 3;
        maxHealth += 10;
        health = maxHealth;
        healLvl += 5;
    }

}

public class FireHero : Hero
{
    public int mana;
    public FireHero(string _name, int _attack, int _health, int _mana)
        : base(_name, _attack, _health)
    {
        mana = _mana;
    }
}

public class WaterHero : Hero
{
    public int mana;
    public WaterHero(string _name, int _attack, int _health, int _mana)
        : base(_name, _attack, _health)
    {
        mana = _mana;
    }
}

public class EarthHero : Hero
{
    public int mana;
    public EarthHero(string _name, int _attack, int _health, int _mana)
        : base(_name, _attack, _health)
    {
        mana = _mana;
    }
}

