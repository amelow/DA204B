using System;

namespace DA204B
{
    public class PetApplication {
         private string name= " ";
         private int age = 0; 
         private bool isFemale;
         
        public string ReadName(){
            Console.WriteLine("What is the name of your pet? ");
            name = Console.ReadLine();
             Console.WriteLine("Name of the pet: "+ name);
            return name;

        }
       public int ReadAge(){
           Console.WriteLine("How old is "+ name + "?");
           age = int.Parse(Console.ReadLine()); 
            Console.WriteLine(name+ " is "+ age + " years old");
        return age;
        }
        public bool CheckIsFemale(){
            Console.WriteLine("Is "+ name+ "female? Answer with yes or no!");
            string checkYesOrNo = Console.ReadLine();
            if(checkYesOrNo=="yes"||checkYesOrNo=="Yes"){
            Console.WriteLine("She is a female");
            return true;
            }
            else if (checkYesOrNo=="no"||checkYesOrNo=="No"){
            Console.WriteLine("He is a male");
            }
            return false;
         
        }
        private static void DisplayInformation(){

        }
        
    }

}
