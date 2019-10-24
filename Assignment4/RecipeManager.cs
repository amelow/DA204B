using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4{
 public class RecipeManager{
    private int maxNmbrOfRecipes = 200;
        private Recipe[] recipeList;

      public RecipeManager(int maxNmbrOfRecipes){
            recipeList = new Recipe[maxNmbrOfRecipes];
        }
        private int FindVacantPosition(){
            for(int i = 0; i < recipeList.Length; i++){
                if (recipeList[i] == null)
                    return i;
            }
            return -1;
        }
        public Recipe GetRecipeAt(int index){
            if (CheckIndex(index))
                return recipeList[index];
            else
                return null;
        }
        public bool CheckIndex(int i) { 
            bool ok = true;
            if (i >= 0 && i < recipeList.Length){
                return ok;
            }
            return ok = false;
        }
        public bool Add(string name, FoodCategory category, string[] ingredients){
            bool ok = false;
            int index = FindVacantPosition();
            if (index >= 0){
            Recipe recipe = new Recipe(ingredients.Length);
            recipe.name = name;
            recipe.ingredients = ingredients;
            recipe.category = category;
    
            recipeList[index] = recipe;
            
            }
            return ok = true;

        }

        public void Add(Recipe recipe){

        }
        

        public int CurrentNumOfItems(){
            int count = 0;
            for(int i = 0; i < recipeList.Length; i++){
                if (recipeList[i] != null)
                    count++;
            }
            return count;
        }
    }
}
