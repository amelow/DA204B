using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Recipe
    {
        private string[] ingredientArray; // declare array of ingredients

        public string[] Ingredients
        {
            get { return ingredientArray; }
            set { ingredientArray = value; }
        }
        public FoodCategory Category { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int MaxNumberOfIngredients
        {
            get { return ingredientArray.Length; }
        }
        public Recipe(int maxNumberOfIngredients)
        {
            ingredientArray = new string[maxNumberOfIngredients]; //create ingredientArray with length maxNumberOfIngredients
            DefaultValues(); //set values to default
        }

        public Recipe(Recipe other)
        {
            this.Name = other.Name;
            this.Category = other.Category;
            this.Description = other.Description;
            this.ingredientArray = new string[other.Ingredients.Length];
            for (int i = 0; i < other.Ingredients.Length; i++)
            {
                this.Ingredients[i] = other.Ingredients[i];
            }
        }

     
        public bool AddIngredient(string value)
        {
            int index = FindVacantPosition(); //to find vacant position, -1 if none
            if (index >= 0)
            {
                ingredientArray[index] = value;
                return true;
            }
            return false;
        }
        public string GetIngredientAt(int index)
        {
            string value;

            if (CheckIndex(index))
                value = ingredientArray[index];
            else
                value = "No ingredient";
            return value;
        }
       
        public bool ChangeIngredientAt(int index, string value)
        {
            if (CheckIndex(index))
            {
                ingredientArray[index] = value;
                return true;
            }
            return false;
        }
        
        public bool DeleteIngredientAt(int index)
        {
            if (CheckIndex(index))
            {
                ingredientArray[index] = string.Empty;
                return true;
            }
            return false;
        }
        public void DefaultValues()
        {
            for (int i = 0; i < ingredientArray.Length; i++)
                ingredientArray[i] = string.Empty;
            Name = string.Empty;
            Category = FoodCategory.Vegetarian; // set category
            Description = string.Empty;
        }
        private int FindVacantPosition()
        {
            for (int i = 0; i < ingredientArray.Length; i++)
            {
                if (string.IsNullOrEmpty(ingredientArray[i]))
                    return i;
            }
            return -1; // if no vacant position found return -1
        }

 
        private bool CheckIndex(int index)
        {
            return (index >= 0 && index < ingredientArray.Length);
        }
        
        public int GetCurrentNumOfIngredients()
        {
            int count = 0;
            for (int i = 0; i < ingredientArray.Length; i++)
            {
                if (!string.IsNullOrEmpty(ingredientArray[i]))
                    count++;
            }
            return count;
        }

        public override string ToString()
        {
            int chars = Math.Min(Description.Length, 15);
            string descriptionText = Description.Substring(0, chars);

            if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "No description!";

            string textOut = string.Format("{0, -20} {1,4}      {2, -12}   {3, -15}",
                            Name, GetCurrentNumOfIngredients(), Category.ToString(), descriptionText);
            return textOut;
        }

    } // close class
}
