using System;
namespace Assignment2
{
    public class Menu
    {
        public void Start(){
            ShowMenu();
        }
        private void ShowMenu(){
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\n             MAIN MENU");
            Console.WriteLine("\n ----------------------------------------");
            Console.WriteLine("Whole numbers with for: 1");
            Console.WriteLine("Floating point numbers with while: 2");
            Console.WriteLine("Currency converter with do-while loop: 3");
            Console.WriteLine("Work schedule: 4");
            Console.WriteLine("Temperature table: 5");
            Console.WriteLine("Exit the program: 0");
            Console.WriteLine("\n ----------------------------------------");
        }
       
    }
}
