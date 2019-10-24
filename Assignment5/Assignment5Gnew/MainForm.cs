using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Amelie Löwe
 * Assignment 5
 * introduction to C# course at the university of Malmö
 */
namespace Assignment5G
{
    public partial class MainForm : Form
    {
        ItemManager itemMngr = new ItemManager(); // Creates an instance of the ItemManager class
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        
        private void InitializeGUI()
        {
            comboBox1.Items.AddRange(Enum.GetNames(typeof(UnitTypes)));//Fetching all the measurements
            comboBox1.SelectedIndex = (int)UnitTypes.cm;//setting the default value to cm
            this.Text = "The Shopping List"; // header text

        }
        //Eventhandler for the add button clicked
        private void AddBtn_Click(object sender, EventArgs e)
        {
            ShoppingItem newItem = GetTaskFromUserInputs();
            if (newItem != null)
            {
                itemMngr.Add(newItem);
                UpdateGUI(newItem);
            }
        }
        
        private void UpdateGUI(ShoppingItem itemObj)
        {
            listBox1.Items.Add(itemObj.ToString()); // Adding the shoppingitems to the listbox
            ClearField();
        }

        private void ClearField() // resetting the input fields
        {
            amountTxt.Text = " ";
            descriptionTxt.Text = " ";
            comboBox1.SelectedIndex = (int)UnitTypes.cm;
        }

        private ShoppingItem GetTaskFromUserInputs()//reading the inputs from the user
        {
            bool parsed;
            Double amount;

            ShoppingItem itemObj = new ShoppingItem();
            if (!string.IsNullOrEmpty(amountTxt.Text))
            {
              parsed = double.TryParse(amountTxt.Text, out amount);
                if (parsed)
                {
                    itemObj.Amount = amount;
                }
            }
           
            itemObj.Unit = (UnitTypes)comboBox1.SelectedIndex;
            if (!string.IsNullOrEmpty(descriptionTxt.Text))
            {
                itemObj.Description = descriptionTxt.Text;
            }
            else
            {
                MessageBox.Show("Please provide a description of the shoppingItem");
            }
               

            return itemObj;
        }

    }

}
