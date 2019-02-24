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
       

        public void Start() {
            Console.WriteLine("In TemperatureTable Class ");
            ShowProgramInfo();
            TemperatureMenu();
            ReadInput();
            Convertions();
            
        }
        private void ShowProgramInfo(){
            Console.WriteLine("\n\n +++++++++ Temperature Conversions +++++++++");
            Console.WriteLine("\n                                              \n");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++ ");
        }
        private void TemperatureMenu(){
            Console.WriteLine("To convert from Celsius to Fahrenheit, press 1.\n");
            Console.WriteLine("To convert from Fahrenheit to Celsius, press 2.");
        }
        private void ReadInput(){
            Console.Write("\n Which conversions do you want to use : ");
            menuInput = Input.ReadDoubleConsole();
            Console.Write("\n You chose number: " + menuInput);
            Console.WriteLine("\n ");
        }
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
        private void ConvertCelToFah(){
            for (int i = 0; i <= 100; i += frequency){
                fahrenheit = (9.0 / 5.0) *(i + 32);
                Console.WriteLine((i).ToString() +
                    "°C" + "       " + fahrenheit.ToString() + "°F");
            }

        }
        private void ConvertFahToCel(){
            for (int i = 0; i <= 100; i += frequency){
                celsius = (5.0 / 9.0) * (i - 32);
                Console.WriteLine((i).ToString() +
                    "°F" + "        " + celsius.ToString() + "°C");
            }

        }
          
        private void DisplayResult() {
            Console.Write("\n Okay im taking you back to the main menu \n ");

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++ \n");

        }
    }
}
