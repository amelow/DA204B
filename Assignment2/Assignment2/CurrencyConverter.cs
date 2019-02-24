using System;
namespace Assignment2
{
/*
 * Second assignment for the Introduction to C#(DA204B) course at the University of Malmö.
 * Author: Amelie Löwe
 * Date: 2019-02-11. 
 */
    public class CurrencyConverter{
        /*
         * The user gives a whole or a floating-point(number  with  a decimal part).
         * Read each of the numbers into your program. 
         * When the user writes in a zero value, sum up the numbers. 
         * Ask the user to give the name of the foreign currency to which the sum is to be converted.
         * Ask the user to specify the exchange rate and read the value
         * Convert the sum to a value in the foreign currency using the exchange rate: value = sum / rate.
         * Mandatory: do – whileloop & decimal type for the numbers. 
        */
        private string nameForeignCurr;
        private decimal inputNum;
        private decimal sumOfNumbers;
        private decimal convertionRate;
        private decimal convertedCurr;

      /*
       * Method that calls all of the other mehods used in this class    
       */
        public void Start(){
            Console.WriteLine("In CurrencyConverter Class");
            ShowProgramInfo();
            ReadInput();
            ConvertCurrency();
            DisplayResult();
        }
        /*
         * Method for displaying the Converters header
         */
        public void ShowProgramInfo() {
            Console.WriteLine("\n\n +++++++++ Currency Converter +++++++++");
            Console.WriteLine("\n        Using a do-while-statement \n");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++ ");
        }
        /*
        * Method for reading different user input, such as the conversion rate and the foreign currency 
        */
        private void ReadInput(){
            Console.WriteLine("Name of the currency you want to convert your money to (ex. USD)");
            nameForeignCurr = Console.ReadLine();
            Console.WriteLine("Please put in the convertion rate from SEK to " + nameForeignCurr);
            convertionRate = decimal.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Please write the amount of money to add (SEK), end with a 0:");
                inputNum = decimal.Parse(Console.ReadLine());
                sumOfNumbers += inputNum;
            }
            while ((Math.Round(inputNum, 7) != 0));


        }
       /*
       * Method for converting the given cuurency from SEK
       */
        private void ConvertCurrency(){
            Console.WriteLine("Calculating new Currency....");
            convertedCurr = (sumOfNumbers / convertionRate);


        }
     /*
      * Displaying the results from the convertions
      */
        private void DisplayResult(){
            Console.WriteLine("Sum of all of the money: " + sumOfNumbers + " SEK");
            Console.WriteLine("Exchange rate from SEK to " + nameForeignCurr+ " is " + convertionRate + " SEK/"+ nameForeignCurr);
            Console.WriteLine("The sum of the converted currency is " + convertedCurr + " " + nameForeignCurr);

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++ \n");

        }
    }
}
