namespace ConsoleApp2;

public class Player
{
    private string _name;
    private double _health;
    private double _damage;
    private double _defense;
    private double _mana;
    private double _experience;
    private int _lvl;
    private int _gold;


    public Player(string name, double health, int damage, int defense, int mana, int lvl, double experience, int gold)
    {
        _name = name;
        _health = health;
        _damage = damage;
        _defense = defense;
        _mana = mana;
        _lvl = lvl;
        _gold = gold;
   
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public double Damage
    {
        get => _damage;
        set => _damage = value;
    }

    public double Defense
    {
        get => _defense;
        set => _defense = value;
    }

    public double Mana
    {
        get => _mana;
        set => _mana = value;
    }

    public double Experience
    {
        get => _experience;
        set => _experience = value;
    }

    public double Health
    {
        get => _health;
        set => _health = value;
    }

    public int Lvl
    {
        get => _lvl;
        set => _lvl = value;
    }

    public int Gold
    {
        get => _gold;
        set => _gold = value;
    }

}