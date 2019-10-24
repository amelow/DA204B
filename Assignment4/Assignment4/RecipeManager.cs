using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Fourth assignment for the Introduction to C#(Da204B) course at the University of Malmö.
 * Author: Amelie Löwe
 */
namespace Assignment4{
    public class RecipeManager{
       
        private Recipe[] recipeArray; //  Array is declaired. storage for all the recipes.

        /// constructor for recipeManager. 
        public RecipeManager(int maxNumOfElements){
            recipeArray = new Recipe[maxNumOfElements]; //Size of array is equal to the maxNumOfElements
        }

        /*Following method handles the recipeArray
        * it loops thru all of the recipes in array and checks if there is an empty spot
        * The method is similar to the method in the recipe.cs class
        */
        private int FindVacantPosition(){
            for (int i = 0; i < recipeArray.Length; i++)
            {
                if (recipeArray[i] == null)
                    return i;
            }
            return -1; // returns -1 because no vacant position is found
        }

        /*Method that checks if there is an empty spot. If yes it adds the recipe*/
        public bool Add(Recipe value){ 
            bool ok = true;
            int index = FindVacantPosition(); 
            if (index >= 0){
                recipeArray[index] = value; 
                return ok;
            }
            return ok = false;

        }

        /*Method that counts the number of elements in the recipeArray(not the ones that are null)*/
        public int CurrerntNumOfItems(){
            int count = 0;
            for (int i = 0; i < recipeArray.Length; i++)
            {
                if (recipeArray[i] != null)
                    count++;
            }
            return count;
        }
        /*The RecipeListToString method converts a string array to a string and returns it*/
        public string[] RecipeListToString(){
            int j = 0;
            int index;
            string[] toString = new string[CurrerntNumOfItems()];
            for (index= 0; index < recipeArray.Length; index++){
                Recipe rec = recipeArray[index];
                if (rec != null){
                    toString[j] = String.Concat(rec);
                    j++;
                }
            }
            return toString;
        }

        /*Returns one element(recipe) at a time*/
        public Recipe GetRecipeAt(int index){
            if (CheckIndex(index))
                return new Recipe(recipeArray[index]);
            else
                return null;
        }

        /*Method that checks if index is in the range of the array*/
        private bool CheckIndex(int index){
            return (index >= 0 && index < recipeArray.Length);
        }
    }
}
