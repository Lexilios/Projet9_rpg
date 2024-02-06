using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

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
    private ElementEnum element;

    public NonElement (string _name, int _attack, int _health, ElementEnum _element)
        :base (_name, _attack, _health) 
    {
        element = _element;
    } 
}

public class ElementEnemy : Enemy
{
    private ElementEnum element;

    public ElementEnemy(string _name, int _attack, int _health, ElementEnum _element)
        : base(_name, _attack, _health)
    {
        element = _element;
    }
   
public class Bandit : NonElement
{
    public Bandit(string _name, int _attack, int _health, ElementEnum _element)
        : base(_name, _attack, _health, _element)
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


public class Golem : ElementEnemy
{
    public Golem(string _name, int _attack, int _health, ElementEnum _element)
        : base(_name, _attack, _health, _element)
    {
        numOfAttack = 3;
    }
        public void Roll (Hero target)
        {
            target.health -= attack * 2;

        }
        public void RockThrow (Hero target)
        {
            target.health -= attack + 2;
        }
        public void GolemTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Golem charged at you!");
            }

            if (choice == 2)
            {
                Roll(target);
                Console.WriteLine("Golem rolled over you!");
            }

            if (choice == 3)
            {
                RockThrow(target);
                Console.WriteLine("Golem threw a rock at you");
            }

            Console.ReadLine();
            Console.Clear();
        }
        public void ElementalAttack()
        {
            // Logique de l'attaque élémentaire en fonction de 'element'
            // Vous pouvez implémenter cela selon les spécificités de chaque élément
            switch (element)
            {
                case ElementEnum.Fire:

                    break;
                case ElementEnum.Water:

                    break;
                case ElementEnum.Earth:

                    break;
                case ElementEnum.NonElement:
                    break;

                default:

                    break;
            }
        }
    }
}



public class Dragon : ElementEnemy
{
    public int armor;

    public Dragon(string _name, int _attack, int _health, int _armor, ElementEnum _element)
        : base(_name, _attack, _health, _element)
    {
        numOfAttack = 4;
        armor = _armor;
    }


    public void Breath(Hero target)
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
            Breath(target);
            Console.WriteLine("Dragon used his element on you!");
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
    public void ElementalAttack()
    {
        // Logique de l'attaque élémentaire en fonction de 'element'
        // Vous pouvez implémenter cela selon les spécificités de chaque élément
        switch (element)
        {
            case ElementEnum.Fire:

                break;
            case ElementEnum.Water:

                break;
            case ElementEnum.Earth:

                break;
            case ElementEnum.NonElement:
                break;

            default:

                break;
        }
    }
}

