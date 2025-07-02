using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp
{
    internal class Store
    {

        public string Name { get; set; }
        public List<Item> Items { get; set; }

        public Store(string name)
        {
            Name = name;
            Items = new List<Item>();
        }

    }
}
