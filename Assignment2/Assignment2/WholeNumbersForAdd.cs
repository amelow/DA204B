using System;
namespace Assignment2
{
/*
 * Second assignment for the Introduction to C#(DA204B) course at the University of Malmö.
 * Author: Amelie Löwe
 * Date: 2019-02-10. 
 */
    public class WholeNumbersForAdd{
        /* Following criteria needs to be met by this class:
         * Read the number of integer values to add.
         * Read each value and add to the sum.
         * Display the total sum.
         * Return to the main menu.  
         * Mandatory: for-loop & int or long for the numbers.
        */
        private int sumOfNumbers;
        private int numOfInput;
        private int index;
        /*
        * Method that calls all of the other mehods used in this class    
        */
        public void Start(){
            Console.WriteLine("In WholeNumbersForAdd Class");
            ShowProgramInfo();
            ReadInput();
            CalculateNumbers();
            DisplayResult();
        }
        private void ShowProgramInfo(){
            Console.WriteLine("\n\n +++++++++ Summation of whole numbers +++++++++");
            Console.WriteLine("\n             Using a for-statement \n");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++ ");
        }
       /*
       * Method for reading the users input       
       */
        private void ReadInput(){
            Console.WriteLine("How many numbers do you want to add?");
            numOfInput = int.Parse(Console.ReadLine());
  
        }
        private void CalculateNumbers(){
            for(index = 1; index <= numOfInput; index++){
                Console.WriteLine("Please give the value number no. " + index + " (whole number) :  ");
                    sumOfNumbers += int.Parse(Console.ReadLine());
            }

        }
        private void DisplayResult(){
            Console.WriteLine("Sum of all numbers:"+ sumOfNumbers);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++ \n");

        }
    }
}
