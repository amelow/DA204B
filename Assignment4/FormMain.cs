using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4{
    public partial class FormMain : Form{
        private const int maxNmbrOfIngredients = 50;
        private const int maxNmbrOfRecipes = 200;
        RecipeManager recipeManager = new RecipeManager(maxNmbrOfRecipes);
        Recipe recipe = new Recipe(maxNmbrOfIngredients);
        public FormMain(){
            InitializeComponent();
            InitializeGUI();
        }
        public void InitializeGUI(){
            recipe.DefaultValues();
            this.Text = "Apus Cookbook";
            categoryBox.DataSource = Enum.GetValues(typeof(FoodCategory));
            

        }

        private void recipeBtn_Click(object sender, EventArgs e){
            UpdateGUI();
            recipe.DefaultValues();

        }

        private void addIngredientsBtn_Click(object sender, EventArgs e){
            FormIngredient formIngredient = new FormIngredient(recipe);
            DialogResult dialogResult = formIngredient.ShowDialog();
            if (dialogResult == DialogResult.OK){
                if (recipe.GetCurrentNumOfIngredients() <= 0){
                    MessageBox.Show("No ingredients specified");
                    recipeManager.Add(recipe);
                    UpdateGUI();
                }
            }
        }
        public void UpdateGUI(){

        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e){
            recipe.category = (FoodCategory)categoryBox.SelectedIndex;
        }
    }
}
