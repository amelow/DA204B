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
 * Fourth assignment for the Introduction to C#(Da204B) course at the University of Malmö.
 * Author: Amelie Löwe
 */
namespace Assignment4{
    public partial class FormIngredients : Form{

        Recipe m_recipe;

        /*Constructor of the formIngredient class*/
        public FormIngredients(Recipe recipe){
            InitializeComponent();
            m_recipe = recipe;

            if (string.IsNullOrEmpty(m_recipe.nameRec)) // default 
                this.Text = "No recipe name";
            else
                this.Text = "Add ingredients to " + m_recipe.nameRec;

            InitializeGui();
        }

        /*Initializes all od the GUI functions*/
        private void InitializeGui(){
            if (m_recipe.ingredient == null)
                m_recipe.ingredient = new string[m_recipe.MaxNumberOfIngredients];

            ingrListBox.Items.Clear();
            toolTip1.SetToolTip(ingredientTxtBox, "Example: 2 dl of milk");
            UpdateGui();
        }
        /*Update the GUi then clear the fields*/
        private void UpdateGui(){
            ingrListBox.Items.Clear();

            numOfIngrLbl.Text = m_recipe.GetCurrentNumOfIngredients().ToString();
            ingrListBox.Items.AddRange(m_recipe.ingredient);
            ingredientTxtBox.Clear();
           
        }
        /*Following methods handle the eventahandlers for the cancel and the Ok button functionality*/
        private void OKbtn_Click(object sender, EventArgs e){

            Console.WriteLine("FormIngredient window Ok!");
        }

        private void btnCancelAddIngr_Click(object sender, EventArgs e){
            Console.WriteLine("FormIngredient window canceled!");
        }

        /*Adds the ingredient when the button is clicked then calls the UpdateGui method*/
        private void btnAddIngr_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(ingredientTxtBox.Text)){
                MessageBox.Show("No ingredients?!"); // no ingredient when addbtn pressed triggers the messagebox
                return;
            }
            m_recipe.AddIngredient(ingredientTxtBox.Text);
            UpdateGui();
        }
    }
}
