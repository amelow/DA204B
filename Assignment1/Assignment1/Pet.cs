using System;
/*
 * First assignment for the Introduction to C#(DA204B) course at the University of Malmö.
 * The exercise was to program a class containing several methods which reads the users input regarding their pets age,gender etc.
 * Author: Amelie Löwe
 * Date: 2019-02-06. 
 */
namespace Assignment1
{
    public class Pet
    {
        /*Declaring all variables*/
        private string name = " ";
        private int age = 0;
        private bool isFemale = true;

        /*Method for reading name of the users pet*/
        public string ReadName(){
            Console.WriteLine("Greetings from the Movie Object! :)" + "\n-----------");
            Console.WriteLine("What is the name of your pet? ");
            name = Console.ReadLine();
            Console.WriteLine("Fetching name -OK" + "\n-----------");
            return name;

        }
        /*Method for reading age of the users pet*/
        public int ReadAge(){
            Console.WriteLine("How old is " + name + "?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Fetching age -OK" + "\n-----------");
            return age;
        }
        /*Method for checking the gender of the users pet*/
        public bool CheckIsFemale(){
            Console.WriteLine("Is " + name + " female? Answer with yes or no!");
            string checkYesOrNo = Console.ReadLine();
            if (checkYesOrNo == "yes" || checkYesOrNo == "Yes")
            {
                Console.WriteLine("Fetching Gender -OK" + "\n-----------");
                return true;
            }
            else if (checkYesOrNo == "no" || checkYesOrNo == "No")
            {
                Console.WriteLine("Fetching Gender -OK" + "\n-----------");
                return isFemale = false;
            }
            else
            {
                Console.WriteLine("Please answer with only Yes or No");
            }
            return isFemale = false;

        }
        /*Method for displaying all the gathered information about the pet*/
        public void DisplayInformation(){
            Console.WriteLine(" Displaying the information" + "\n-----------");
            Console.WriteLine("Your pet name is: " + name);
            Console.WriteLine(name + "'s age is:" + age);
            if (isFemale)
                Console.WriteLine(name + " is a female");
            else
                Console.WriteLine(name + " is a male");


        }

    }

}

