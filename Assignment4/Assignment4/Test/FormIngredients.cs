using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormIngredients : Form
    {
        Recipe recipeObj2; //declare recipeObj2 as type Recipe

        public Recipe Recipe => recipeObj2;

        //constructor
        public FormIngredients(Recipe recipe)
        {
            InitializeComponent();

            recipeObj2 = recipe; // set recipeObj2 to recipe

            InitializeGui();
            UpdateGui();
        }


        private void InitializeGui()
        {
            if (string.IsNullOrEmpty(recipeObj2.Name)) // check if name is given
                this.Text = "No recipe name";
            else
                this.Text = recipeObj2.Name + ": Add ingredients";

            if (recipeObj2.Ingredients == null)
                recipeObj2.Ingredients = new string[recipeObj2.MaxNumberOfIngredients];

            lstIngredients.Items.Clear();
            toolTipIngredient.SetToolTip(txtIngredient, "Example: 2 dl of milk");
        }
        private void UpdateGui()
        {
            lstIngredients.Items.Clear(); //clear ingredients list before writing new list

            lblNumOfIngredients.Text = recipeObj2.GetCurrentNumOfIngredients().ToString(); // write no of ingredients
            lstIngredients.Items.AddRange(recipeObj2.Ingredients); //write ingredients list

            txtIngredient.Clear();
            txtIngredient.Focus();
        }

        private void btnAddIngr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIngredient.Text))
            {
                MessageBox.Show("No ingredient!");
                return;
            }
            recipeObj2.AddIngredient(txtIngredient.Text);
            UpdateGui();
        }
        private void btnEndAddIngr_Click(object sender, EventArgs e)
        {

        }
        private void btnCancelAddIngr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < recipeObj2.MaxNumberOfIngredients; i++)
                recipeObj2.DeleteIngredientAt(i);
        }


        private void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = findSelectedIngredient(lstIngredients.SelectedIndex);
            txtIngredient.Text = recipeObj2.GetIngredientAt(i);
        }
        private int findSelectedIngredient(int index)
        {
            int j = 0;
            int i;

            for (i = 0; i < recipeObj2.MaxNumberOfIngredients; i++)
            {
                if (recipeObj2.GetIngredientAt(i) != null)
                {
                    if (j == index)
                        break;
                    j++;
                }
            }
            return i;

        }
    }
}
