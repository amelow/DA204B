using System;
namespace Assignment2{
/*
 * Second assignment for the Introduction to C#(DA204B) course at the University of Malmö.
 * Author: Amelie Löwe
 * Date: 2019-02-11. 
 */

    public class Menu{
        private int choice;
        private bool showDisplay = true;

        public void Start(){
            while (showDisplay){
                ShowMenu();
                readUserInput();
                handleDisplay();
            }
        }
        private void ShowMenu(){
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\n             MAIN MENU");
            Console.WriteLine("\n ----------------------------------------");
            Console.WriteLine("Exit the program:                      0");
            Console.WriteLine("Whole numbers with for- statement:     1");
            Console.WriteLine("Floating point numbers with while-loop:2");
            Console.WriteLine("Currency converter with do-while loop: 3");
            Console.WriteLine("Work schedule:                         4");
            Console.WriteLine("Temperature table:                     5");
            Console.WriteLine("\n ----------------------------------------");
        }
        private void readUserInput(){
            Console.WriteLine("Your choice: ");
            choice = Input.ReadIntegerConsole();


        }
        private void handleDisplay(){
            switch (choice)
            {
                case 0:
                    showDisplay = false;
                    break;
                case 1:
                    WholeNumbersForAdd wholeNumbersForAdd = new WholeNumbersForAdd();
                    wholeNumbersForAdd.Start();
                    break;
                case 2:
                    FloatingPointsNumberWhileAdd floatingPointsNumberWhileAdd = new FloatingPointsNumberWhileAdd();
                    floatingPointsNumberWhileAdd.Start();
                    break;
                case 3:
                    CurrencyConverter currencyConverter = new CurrencyConverter();
                    currencyConverter.Start();
                    break;
                case 4:
                    WorkingSchedule workingSchedule = new WorkingSchedule();
                    break;
                case 5:
                    TemperatureTable temperatureTable = new TemperatureTable();
                    break; 
            }
        }

    }
}
