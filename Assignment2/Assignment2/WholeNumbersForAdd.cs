using System;
namespace Assignment2
{
    public class WholeNumbersForAdd{
        private int sumOfNumbers;
        private int numOfInput;
        private int index;
       
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
