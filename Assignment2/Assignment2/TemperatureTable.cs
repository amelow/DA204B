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
        private double menuInput;
        private double celsius;
        private double fahrenheit;
        private int frequency = 4;

        /*
        * Method that calls all of the other mehods used in this class    
        */
        public void Start() {
            Console.WriteLine("In TemperatureTable Class ");
            ShowProgramInfo();
            TemperatureMenu();
            ReadInput();
            Convertions();   
        }
        /*
         * Method for displaying the Temperature converters header
         */
        private void ShowProgramInfo(){
            Console.WriteLine("\n\n +++++++++ Temperature Conversions +++++++++");
            Console.WriteLine("\n                                              \n");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++ ");
        }
        /*
         * A smaller menu for choosing what kind of convertions the user wants.
         * When pressed either 1 or 2 the values will be displayed and then the user gets directly 
         * returned to the main menu
         */
        private void TemperatureMenu(){
            Console.WriteLine("To convert from Celsius to Fahrenheit, press 1.\n");
            Console.WriteLine("To convert from Fahrenheit to Celsius, press 2.");
        }
        /*
         * Method for displaying the Converters header
         */
        private void ReadInput(){
            Console.Write("\n Which conversions do you want to use : ");
            menuInput = Input.ReadDoubleConsole();
            Console.Write("\n You chose number: " + menuInput);
            Console.WriteLine("\n ");
        }
        /*
         * Basically showing a header for the differerent types of conversions, depending on the users input
         */
        private void Convertions(){
            if (menuInput == 1){
                Console.WriteLine("\n\n +++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("\n           Celsius to Fahrenheit             \n");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
                ConvertCelToFah();
            }
            else if (menuInput == 2){
                Console.WriteLine("\n\n ++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("\n           Fahrenheit to Celsius             \n");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");
                ConvertFahToCel();
            }
        }
        /*
         * Method for looping thru the 100 first temperatures (0-100) at the frequency or rate of 4. 
         * Then converting from celcius to fahrenheit by using the formula and printing it as a table.
         */
        private void ConvertCelToFah(){
            for (int i = 0; i <= 100; i += frequency){
                fahrenheit = (9.0 / 5.0) *(i + 32);
                Console.WriteLine((i) + "°C" + "       " + fahrenheit+ "°F");
            }

        }
        /*
         * Method for looping thru the 100 first temperatures (0-100) at the frequency or rate of 4. 
         * Then converting from fahrenheit to celcius by using the formula and printing it as a table.
         * Here i had to use toString(0.00) after celcius otherwise it would have printed way to many decimals. 
         * I tried Math.round but that gives no decimals and i didnt know if that was allowed :)
         */
        private void ConvertFahToCel(){
            for (int i = 0; i <= 100; i += frequency){
                celsius = (5.0 / 9.0) * (i - 32);
                Console.WriteLine((i) +"°F" + "       " + celsius.ToString("0.00") + "°C");
            }

        }
          
        private void DisplayResult() {
            Console.Write("\n Okay im taking you back to the main menu \n ");

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++ \n");

        }
    }
}
