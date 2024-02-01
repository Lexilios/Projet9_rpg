public class hero : human
{
    public int PVlvl = 0, MaxPV = 10;
    public hero(string _name, int _attacks, int _health, int _mana) 
        : base(_name, _attacks, _health, _mana)
    {
    }
    public void levelUp()
    {
        Console.WriteLine("GG! You leveled Up.");
        Console.WriteLine("Attack + 3");
        Console.WriteLine("PV + 5");
        Console.WriteLine("Heal + 5");
        Console.WriteLine("Mana + 10");
        Console.ReadLine();
        Console.Clear();

        attack += 3;
        MaxPV = 5;
        PM += 10;
        PV = MaxPV;
        PVlvl += 5;
    }
}