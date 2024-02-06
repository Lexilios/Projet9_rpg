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
public class ElementHero : Hero
{
    public int mana;
    private ElementEnum element;

    public ElementHero(string _name, int _attack, int _health, int _mana, ElementEnum _element)
        : base(_name, _attack, _health)
    {
        mana = _mana;
        element = _element;
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

    // ajouter d'autres fonctionnalités spécifiques aux héros élémentaires la
}

