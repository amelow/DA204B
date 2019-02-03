using System;

namespace DA204B
{
    public class PetApplication {
         private string name; //private int age; private bool isFemale;
         
        public string ReadName(){
            Console.WriteLine("What is the name of your pet? ");
            name = Console.ReadLine();
            return name;

        }
/*        private int ReadAge(){

        }
        private bool CheckIsFemale(){

        }
        private static void DisplayInformation(){

        }
        */
    }

}
