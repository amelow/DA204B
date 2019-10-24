using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Fourth assignment for the Introduction to C#(Da204B) course at the University of Malmö.
 * Author: Amelie Löwe
 */
namespace Assignment4
{
    public class Recipe
    {
        private string[] ingredientArray; // instatiate array of ingredients
        public string nameRec { get; set; } // getters and setters for the name of the recipe
        public FoodCategory CategoryEnum { get; set; } // getters and setters for the different types of recipes
        public string descriptionRec { get; set; }// getters and setters for the recipe description textbox (instructions etc)

        public string[] ingredient{ // getter/ settetr for the ingredient array
            get { return ingredientArray; }
            set { ingredientArray = value; }
        }
        
        public int MaxNumberOfIngredients{ // capacity of the array
            get { return ingredientArray.Length; }
        }

        // recipe constructor
        public Recipe(int maxNumberOfIngredients){ 
            ingredientArray = new string[maxNumberOfIngredients]; // new object with the size of the array set to the maxNumberOfIngredients
            DefaultValues(); // calls the default value method
        }
        
        public Recipe(Recipe rec) {
            this.nameRec = rec.nameRec;
            this.CategoryEnum = rec.CategoryEnum;
            this.descriptionRec = rec.descriptionRec;
            this.ingredientArray = new string[rec.ingredient.Length];
            for (int i = 0; i < rec.ingredient.Length; i++) {
                this.ingredient[i] = rec.ingredient[i];
            }
        }

        /*
         * Method that handles the add ingredient functions
         * If true it saves the string in the array 
         */
        public bool AddIngredient(string value){ // parameter for recieving a new ingredient string
            bool ok = true;
            int index = FindVacantPosition(); // checks if there is a vacant position
            if (index >= 0){ 
                ingredientArray[index] = value; // value gets put in the arr at the free position (index)
                return ok;
            }
            return ok= false;
        }

        /*Following method handles the ingredientarray
        * it loops thru all of the ingredients in array and checks if there is an empty spot
        */
        private int FindVacantPosition(){
            for (int index = 0; index < ingredientArray.Length; index++)
            {
                if (string.IsNullOrEmpty(ingredientArray[index]))
                    return index;
            }
            return -1; // no vacant position found
        }

        /*Method that checks if index is in the range of the array*/
        private bool CheckIndex(int index){
            return (index >= 0 && index < ingredientArray.Length);// should be greater or equal to zero but not bigger than the array
        }

        /*Method that handles the default initalizations*/
        public void DefaultValues(){
            for (int index = 0; index < ingredientArray.Length; index++) // For-loop to set all elemtents in the array as empty
                ingredientArray[index] = string.Empty;
            nameRec = string.Empty; // empty from start
            CategoryEnum = FoodCategory.Meat; // setting meat as the standard category option
            descriptionRec = string.Empty;// empty from start
        }

        /*Following method handles the current size of the ingredient*/
        public int GetCurrentNumOfIngredients(){
            int count = 0;
            for (int index = 0; index < ingredientArray.Length; index++)
            {
                if (!string.IsNullOrEmpty(ingredientArray[index]))
                    count++;
            }
            return count;
        }

        /*The tostring method returns a formatted string with the recipe values*/
        public override string ToString(){
            int chars = Math.Min(descriptionRec.Length, 15);
            string descriptionText = descriptionRec.Substring(0, chars);

            if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "No description!";

            string textOut = string.Format("{0, -20} {1,4}      {2, -12}   {3, -15}",
                            nameRec, GetCurrentNumOfIngredients(), CategoryEnum.ToString(), descriptionText);
            return textOut;
        }

    } 
}

