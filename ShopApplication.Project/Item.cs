using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication.Project
{
    public class Item
    {
        public string Name { get; set; }

        public int Price { get; set; }

       // public int Quantity { get; set; }
       //public Item(string name, decimal price, int quantity)

        public Item(string name, int price)
        {
            Name = name;
            Price = price;           
        }
    }
}