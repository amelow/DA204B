using System;

namespace DA204B
{
    public class PetApplication {
         private string name= " ";
         private int age = 0; 
         private bool isFemale= true;
         
        public string ReadName(){
            Console.WriteLine("What is the name of your pet? ");
            name = Console.ReadLine();
             Console.WriteLine("Fetching name -OK"+ "\n-----------");
            return name;

        }
       public int ReadAge(){
           Console.WriteLine("How old is "+ name + "?");
           age = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Fetching age -OK"+ "\n-----------");
        return age;
        }
        public bool CheckIsFemale(){
            Console.WriteLine("Is "+ name+ " female? Answer with yes or no!");
            string checkYesOrNo = Console.ReadLine();
            if(checkYesOrNo=="yes"||checkYesOrNo=="Yes"){
            Console.WriteLine("She is a female");
             Console.WriteLine("Fetching Gender -OK"+ "\n-----------");
            return true;
            }
            else if (checkYesOrNo=="no"||checkYesOrNo=="No"){
            Console.WriteLine("He is a male");
             Console.WriteLine("Fetching Gender -OK"+ "\n-----------");
            return isFemale=false;
            }else{
            Console.WriteLine("Please answer with only Yes or No");   
            }
            return isFemale=false;
           
        }
        public void DisplayInformation(){
        Console.WriteLine(" Displaying the information"+ "\n-----------");
        Console.WriteLine("Your pet name is: "+ name);
        Console.WriteLine(name+"'s age is:"+ age);
        if (isFemale)
                Console.WriteLine(name + " is a female");
            else
                Console.WriteLine(name + " is a male");


        }
        
    }

}
