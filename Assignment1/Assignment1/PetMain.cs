using System;

namespace Assignment1
{
    class MainClass
    {   /*Calls the methods of the Pet.cs class*/
        public static void Main(string[] args)
        {
                Pet pet = new Pet(); // creates a new Pet object
                pet.ReadName();
                pet.ReadAge();
                pet.CheckIsFemale();
                pet.DisplayInformation();
            }
        }
    }

