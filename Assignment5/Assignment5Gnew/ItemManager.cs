using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Amelie Löwe
 * Assignment 5
 * introduction to C# course at the university of Malmö
 */
namespace Assignment5G
{
    public class ItemManager
    {
        private List<ShoppingItem> itemList; //declaring a list
        public ItemManager()
        {
            itemList = new List<ShoppingItem>();//creating the list object
        }
        public int Count //returns items in list
        {
            get => itemList.Count;
        }

        public bool Add(ShoppingItem newItem) //ads shopping obj to list
        {
            ShoppingItem shoppingObj = new ShoppingItem(newItem);
            itemList.Add(shoppingObj);
            
            return true;
        }
      

    }
}
