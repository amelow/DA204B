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
namespace Assignment4
{
    public partial class FormMain : Form{
        private const int maxNumOfRecipes = 50; // maximum amount of recipes 
        private const int maxNumOfIngredients = 20; // maximum amount of ingredient for each recipe 


        Recipe recipe = new Recipe(maxNumOfIngredients); // recipe object which size equals to the maximum amount of ingredient for each recipe 
        RecipeManager recipeMgr = new RecipeManager(maxNumOfRecipes); //recipemanager object which size equals to the maxNumOfRecipes

        //constructor for the formMain class
        public FormMain(){
            InitializeComponent();
            InitializeGui();
        }
        /*Initializes all of the start values*/
        private void InitializeGui(){
            cboCategory.DataSource = Enum.GetValues(typeof(FoodCategory)); // gets the standard option for the categories
            this.Text = "Apus Cook Book"; // header text 
            lblNumOfRecipes.Text = "0";  
            recipe.DefaultValues(); // call upon the default value  method in the recipe class
            UpdateGUI();
            
        }
        /*Method for the functionality of a add ingredient button click*/
        private void btnAddIngredients_Click(object sender, EventArgs e){
            FormIngredients formIngr = new FormIngredients(recipe); // create a formIngredient object
            DialogResult dlgResult = formIngr.ShowDialog(); // formingredient window appears
            if (dlgResult == DialogResult.OK){ // checks if ok button is pressedS
                if (recipe.GetCurrentNumOfIngredients() <= 0){ // if no ingredients added- messagebox gets triggered
                    MessageBox.Show("OBS...No ingredients Specified!");
                    recipeMgr.Add(recipe); // adds recipe to the recipe manager
                    UpdateGUI();
                }
            }
        }
        /*Method for the functionality of a add recipe button click*/
        private void btnAddRecipe_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(recipe.nameRec)){ // checks if recipe name is added
                MessageBox.Show("No recipe name!?"); // reminder to add name next time
            }
            recipe.CategoryEnum = (FoodCategory)cboCategory.SelectedIndex; // gets selected foodcategory
            recipe.nameRec = NameOfRecipeTxtBox.Text.Trim(); // gets the name of the recipe
            recipe.descriptionRec = txtDescription.Text.Trim(); // Ande the description
      
            recipeMgr.Add(recipe); // adds all to the recipemanager then updates the gui
            UpdateGUI();
            recipe.DefaultValues(); // return to basic default values when done
        }

        /*Method for the GUI, updates all affected controls */
        private void UpdateGUI(){
            lblNumOfRecipes.Text = recipeMgr.CurrerntNumOfItems().ToString();
            string[] recipeListBoxStr = recipeMgr.RecipeListToString();
            recipeList.Items.Clear();
            recipeList.Items.AddRange(recipeListBoxStr);
            InitializeOutput();
            
        }
     
        private void InitializeOutput(){
            NameOfRecipeTxtBox.Text = recipe.nameRec;
            cboCategory.SelectedItem = recipe.CategoryEnum;
            txtDescription.Text = recipe.descriptionRec;
            NameOfRecipeTxtBox.Text = " "; // sets the name box to empty
            txtDescription.Text = " "; // clears the descriptionfield
        }

        /*Methods for all of the changes in the Name of Recipes field,
         * Description field and the food-category combobox 
         */
        private void txtNameOfRecipe_TextChanged(object sender, EventArgs e){
            recipe.nameRec = NameOfRecipeTxtBox.Text.Trim();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e){
            recipe.descriptionRec = txtDescription.Text.Trim();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e){
            recipe.CategoryEnum = (FoodCategory)cboCategory.SelectedIndex;
        }

    }
}
