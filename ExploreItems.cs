using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ExploreItems
    {
        private string _name;
        public int _id ;
        static public int _iid = 1;

        public ExploreItems(string name)
        {
            _name = name;
            _id = _iid++;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
