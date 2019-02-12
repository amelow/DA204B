using System;
namespace Assignment2
{/*
 * Second assignment for the Introduction to C#(DA204B) course at the University of Malmö.
 * Author: Amelie Löwe
 * Date: 2019-02-10. 
 */
    public class FloatingPointsNumberWhileAdd{
        /*
         * Repeat to read a number from the user into your program.
         * When the user writes in a zero value, sum up the numbers.
         * Display the result
         * Return to the Main Menu.
         * Mandatory: whileloop & double type for the numbers.        
          */
        private int sumOfNumbers;

        public void Start() {
            Console.WriteLine("In FloatingPointsNumberWhileAdd Class ");
            ShowProgramInfo();
        }
        private void ShowProgramInfo(){
            Console.WriteLine("\n\n +++++++++ Summation of Float numbers +++++++++");
            Console.WriteLine("\n             Using a while-statement \n");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++ ");
        }
    }
}
