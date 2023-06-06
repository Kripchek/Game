using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Knight : Player
    {
        string _specialization;
        public Knight(string name,string specialization, double health, int damage, int defense, int mana, int lvl, double experience, int gold) : base(name, health, damage, defense, mana, lvl, experience, gold)
        {
            _specialization = specialization;
        }

        public string Specialization
        {
            get => _specialization;
            set => _specialization = value;
        }
    }
}
