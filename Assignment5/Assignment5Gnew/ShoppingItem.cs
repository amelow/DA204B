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
    public class ShoppingItem
    {
        private string description;
        private double amount;
        private UnitTypes unit;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public UnitTypes Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        /*Constructors*/
        public ShoppingItem()
        {

        }
        public ShoppingItem(ShoppingItem other)
        {
            this.amount = other.amount;
            this.unit = other.unit;
            this.description = other.description;

        }
        public ShoppingItem(string description, double amount, UnitTypes unit)
        {
            this.description = description;
            this.amount = amount;
            this.unit = unit;
        }
        public override string ToString() // to string method
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Description);
            sb.Append("\t");

            sb.Append(Amount);
            sb.Append("\t");
            sb.Append(Unit);

            return sb.ToString();
        }


    }
}
