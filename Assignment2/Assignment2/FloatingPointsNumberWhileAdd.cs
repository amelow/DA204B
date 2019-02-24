using System;
namespace Assignment2
{/*
 * Second assignment for the Introduction to C#(DA204B) course at the University of Malmö.
 * Author: Amelie Löwe
 * Date: 2019-02-11. 
 */
    public class FloatingPointsNumberWhileAdd{
        /*
         * Repeat to read a number from the user into your program.
         * When the user writes in a zero value, sum up the numbers.
         * Display the result
         * Return to the Main Menu.
         * Mandatory: whileloop & double type for the numbers.        
          */
        private double sumOfNumbers;
        private bool isDone = false;
        private double input;

      /*
      * Method that calls all of the other mehods used in this class    
      */
        public void Start(){
            Console.WriteLine("In FloatingPointsNumberWhileAdd Class ");
            ShowProgramInfo();
            ReadInputAndSum();
            DisplayResult();
        }
        private void ShowProgramInfo(){
            Console.WriteLine("\n\n +++++++++ Summation of Float numbers +++++++++");
            Console.WriteLine("\n             Using a while-statement \n");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++ ");
        }
      /*
       * Method for reading the users input, and then adding them together.      
       */
        private void ReadInputAndSum(){
            while (!isDone){
                Console.Write("Write a number to add to the sum, end with a 0: ");
                input = double.Parse(Console.ReadLine());
                sumOfNumbers += input;

                if ((Math.Round(input, 7) == 0.0)){
                    isDone = true;
                }
            }
        }
        private void DisplayResult(){
            Console.WriteLine("Sum of all numbers:" + sumOfNumbers);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++ \n");

        }
    }
}
