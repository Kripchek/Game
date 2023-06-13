using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Shop
    {
        private string _name;
        public int _id;
        static public int _iid = 1;
        private int _gold;

        public Shop(string name,int gold)
        {
            _name = name;
            _id = _iid++;
            _gold = gold;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int Gold
        {
            get => _gold;
            set => _gold = value;
        }
    }
}
