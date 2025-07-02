using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp
{
    internal class Item
    {
        public string itemName { get; set; }

        public Item(string name)
        {
            itemName = name;
        }
    }
}
