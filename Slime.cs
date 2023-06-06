using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Slime : Enemy
    {
        double _def;
        int _gold;
        public Slime(double health, int damage, double def, int lvl, int gold) : base(health, damage, lvl)
        {
            _gold = gold;
            _def = def;
        }
        public int Gold
        {
            get => _gold;
            set => _gold = value;
        }
        public double Def
        {
            get => _def;
            set => _def = value;
        }
    }
}
