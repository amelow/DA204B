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
        return age;
        }
        private bool CheckIsFemale(){
            return true;
        }
        private static void DisplayInformation(){

        }
        
    }

}
