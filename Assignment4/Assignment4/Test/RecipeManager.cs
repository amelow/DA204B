using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class RecipeManager
    {
        /// <summary>
        /// declare array of type Recipe to hold recipes
        /// </summary>
        private Recipe[] recipeArray;

        /// constructor
        public RecipeManager(int maxNumOfElements)
        {
            recipeArray = new Recipe[maxNumOfElements]; //create array of recipes with length maxNumOfElements
        }


        private int FindVacantPosition()
        {
            for (int i = 0; i < recipeArray.Length; i++)
            {
                if (recipeArray[i] == null)
                    return i;
            }
            return -1; // if no vacant position found return -1
        }

        private bool CheckIndex(int index)
        {
            return (index >= 0 && index < recipeArray.Length);
        }

       
        public bool Add(Recipe recipe)
        {
            int index = FindVacantPosition();
            return ChangeRecipe(index, recipe);
        }

        /// <summary>
        /// count number of recipes in recipeArray
        /// </summary>
        /// <returns>current number of recipes</returns>
        public int GetCurrentNumOfRecipes()
        {
            int count = 0;
            for (int i = 0; i < recipeArray.Length; i++)
            {
                if (recipeArray[i] != null)
                    count++;
            }
            return count;
        }
        public string[] RecipeArrayToString()
        {
            string[] result = new string[GetCurrentNumOfRecipes()]; //create result array object
            int j = 0;

            // for loop to find all recipes in recipeArray
            for (int i = 0; i < recipeArray.Length; i++)
            {
                Recipe r = recipeArray[i];
                if (r != null)
                {
                    result[j] = r.ToString();
                    j++; // count number of recipes
                }
            }
            return result;
        }
        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))

                return new Recipe(recipeArray[index]);
            else
                return null;
        }
        public bool ChangeRecipe(int index, Recipe recipe)
        {
            if (CheckIndex(index))
            {
                recipeArray[index] = new Recipe(recipe); // add recipe to array
                return true;
            }
            return false;
        }
    }
}