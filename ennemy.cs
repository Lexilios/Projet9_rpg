using System.Security.Cryptography.X509Certificates;

public class Enemy : Person
{
    public int numOfAttack;

    public Enemy(string _name, int _attack, int _health)
        : base(_name, _attack, _health)
    {
    }

 

    public int EChoice()
    {
        int eChoice;
        Random ran = new Random();
        eChoice = ran.Next(1, numOfAttack + 1);
        return eChoice;
    }
}

public class NonElement : Enemy
{
    public NonElement (string _name, int _attack, int _health)
        :base (_name, _attack, _health) 
    {
        
    } 
}

public class FireEnemy : Enemy
{
    public FireEnemy(string _name, int _attack, int _health)
        : base(_name, _attack, _health)
    {

    }
}

public class WaterEnemy : Enemy
{
    public WaterEnemy(string _name, int _attack, int _health)
        : base(_name, _attack, _health)
    {

    }
}

public class EarthEnemy : Enemy
{
    public EarthEnemy(string _name, int _attack, int _health)
        : base(_name, _attack, _health)
    {

    }
}







public class Bandit : Enemy
{
    public Bandit(string _name, int _attack, int _health)
        : base(_name, _attack, _health)
    {
        numOfAttack = 2;
    }
    public void Stab(Hero target)
    {
        target.health -= attack + 2;
    }

    public void BanditTurn(int choice, Hero target)
    {
        if (choice == 1)
        {
            NormAttack(target);
            Console.WriteLine("Bandit whacked you!");

        }

        if (choice == 2)
        {
            Stab(target);
            Console.WriteLine("Bandit stabed you!");

        }

        Console.ReadLine();
        Console.Clear();
    }
}

public class Golem : Enemy
{
    public Golem(string _name, int _attack, int _health)
        : base(_name, _attack, _health)
    {
        numOfAttack = 3;
    }
    public void Slash (Hero target)
    {
        target.health -= attack + 4;
    }

    public void ShieldBash(Hero target)
    {
        target.health -= attack + 2;
    }

    public void KnightTurn (int choice, Hero target)
    {
        if (choice == 1)
        {

        }
    }

}



public class Dragon : Enemy
{
    public int armor;

    public Dragon(string _name, int _attack, int _health, int _armor)
        : base(_name, _attack, _health)
    {
        numOfAttack = 4;
        armor = _armor;
    }


    public void FireBreath(Hero target)
    {
        target.health -= attack * 2;
    }

    public void Claw(Hero target)
    {
        target.health -= attack + 3;
    }

    public void Bite(Hero target)
    {
        target.health -= attack + 4;
    }

    public void DragonTurn(int choice, Hero target)
    {
        if (choice == 1)
        {
            NormAttack(target);
            Console.WriteLine("Dragon screamed at you!");
        }

        if (choice == 2)
        {
            FireBreath(target);
            Console.WriteLine("Dragon used flamethrower on you!");
        }

        if (choice == 3)
        {
            Claw(target);
            Console.WriteLine("Dragon clawed you!");
        }

        if (choice == 4)
        {
            Bite(target);
            Console.WriteLine("Dragon bite you!");
        }

        Console.ReadLine();
        Console.Clear();
    }

}
