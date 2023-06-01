namespace ConsoleApp3;

public class Enemy
{
     private double _health;
     private int _damage;
     private int _lvl;

     public Enemy(double health, int damage, int lvl)
     {
          _damage = damage;
          _health = health;
          _lvl = lvl;
     }

     public double Health
     {
          get => _health;
          set => _health = value;
     }

     public int Damage
     {
          get => _damage;
          set => _damage = value;
     }

     public int Lvl
     {
          get => _lvl;
          set => _lvl = value;
     }
}