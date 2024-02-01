public class human
{
    public int attack;
    public int PM;
    public int PV;
    public string name;

    public human(string _name, int _attacks, int _health, int _mana)
    {
        name = _name;
        attack = _attacks;
        PV = _health;
        PM = _mana;
    }

    public void Printstats()
    {
        Console.WriteLine("{0} stats : ", name);
        Console.WriteLine("{0} attack : ", attack);
        Console.WriteLine("{0} mana : ", PM);
    }

}