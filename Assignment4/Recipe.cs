using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4{
  public class Recipe{
        private const int numOfIngredients= 20;
        private string[] ingredientArray;
        public string[] ingredients;
        public string name{
            get;
            set;
        }
        public FoodCategory category{
            get;
            set;
        }
        public string description{
            get;
            set;
        }
     
        public int maxNmbrOfIngredients{
            get{
                return ingredientArray.Length;
            }
        }

       // public static string Name { get; internal set; }

        public Recipe(int maxNmbrOfIngredients){
            ingredientArray = new string[maxNmbrOfIngredients];
            DefaultValues();
        }
        public void DefaultValues(){
            for (int i = 0; i < ingredientArray.Length; i++)
                ingredientArray[i] = string.Empty;
            name = string.Empty;
            category = FoodCategory.Vegetarian;
            description = string.Empty;
        }
        public bool AddIngredient(string value){
            bool ok = true;
            int i = FindVacantPosition();
            if (i >= 0){
                value = ingredientArray[i];
                return ok;
            }
            
            return ok =false;
        }
        public bool CheckIndex(int i){
            bool ok = true;
            if(i >= 0&& i < ingredientArray.Length) {
                return ok;
            }
            return ok = false;
        }
      
        public int FindVacantPosition(){
            for (int i = 0; i < ingredientArray.Length; i++){
                if (string.IsNullOrEmpty(ingredientArray[i])){
                    return 1;
                }

            }
            return -1;

        }
        public bool ChangeIngredientAt(int i , string value){
            bool ok = true;
            if (CheckIndex(i)){
                ingredientArray[i] = value;
                return ok;
            }
            else{
                return ok = false;
            } 

        }
        public int GetCurrentNumOfIngredients(){
            int count= 0;
            for(int i = 0; i < ingredientArray.Length; i++){
                if (!string.IsNullOrEmpty(ingredientArray[i]))
                    count++;
            }
            return count;
        }
        public override string ToString(){
            int chars = Math.Min(description.Length, 15);
            string descriptionTxt = description.Substring(0, chars);
            if (string.IsNullOrEmpty(descriptionTxt))
                descriptionTxt = "No description!";
            string txtOut = string.Format("{0,-20}{1,4}{2,-12}{3,15}", name,GetCurrentNumOfIngredients(),category.ToString(),descriptionTxt);
            return base.ToString() ;
        }
    }
}
