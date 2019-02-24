using System;
namespace Assignment2{
/*
 * Second assignment for the Introduction to C#(DA204B) course at the University of Malmö.
 * Author: Amelie Löwe
 * Date: 2019-02-24. 
 */
    public class TemperatureTable{
        /*
         * Write a class that calculates temperatures from 0 to 100 degrees Celsius to corresponding Fahrenheit values.
         * Show the results as a table rounded to whole numbers,as in the figure shown here.
         * Formulas used:
         * toCelsius = 5.0 / 9.0 * (valueToConvert - 32)  
         * toFahrenheit = 9.0 / 5.0 * valueToConvert + 32.0  
         */
        public void Start() {
            Console.WriteLine("In TemperatureTable Class ");
            ShowProgramInfo();
            DisplayResult();
        }
        private void ShowProgramInfo(){
            Console.WriteLine("\n\n +++++++++ Temperature Conversions +++++++++");
            Console.WriteLine("\n                                              \n");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++ ");
        }
    
    private void DisplayResult() {
        Console.WriteLine("Sum of all numbers:" );
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++ \n");

    }
}
}
