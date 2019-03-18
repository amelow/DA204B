using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3{
    /* The Third Assignment for the Introduction to C#(DA204B) course at the University of Malmö
    * Author: Amelie Löwe
    * Date: 2019-03-17
    */
    public class BMICalculator{
        /*
        * Following class is the BMI calculator class of the program. Its main task is to deal with the BMI calculations that gets requested by the MainForm
        * Also it tests the input of the user and calculates the result.
        */
        //Initializing my variables
        private string name = "no Name";
        private double heightReading;
        private double weightReading;
        private double BMI;
        private Values values;
        private int power = 2;

        public enum Values{
            metric,
            US
        }
        /*
         *The ValidateInput method checks so that neiter the Weight input nor the Height can be 0 or smaller. 
        */
        public bool ValidateInput(double weightReading, double heightReading){
            if (weightReading > 0 && heightReading > 0){
                return true;
            }
            return false;
        }
        /*Setter for my values*/
        public void setValues(Values values){
            this.values = values;
        }
        /*Getter for my values*/
        public Values getValues() {
            return values;
        }
        /*
         * Setter for The Name input, it also checks if the input is coorect
         */
        public void setName(string value){
            if (!string.IsNullOrEmpty(value)){ 
                name = value;

            }
        }
        /*Getter method for the name function*/
        public string getName(){
            return name;
        }
        /*Setter for The users Height*/
        public void setHeight(double heightReading){
            this.heightReading = heightReading;
        }
        /*Getter for the Height value*/
        public double getHeight(){
            return heightReading;
        }
        /*Setter the Weight input field*/
        public void setWeight(double weightReading){
            this.weightReading = weightReading;
        }
        /*Getter for the Weight variable */
        public double getWeight(){
            return weightReading;
        }
        /*Getter for the BMI variable */
        public double getBMI(){
            return BMI;
        }
        /*
         * Following function checks if the in parameter is i the Metric unit or in the US unit.
         * Depending on the value(uses the enums for this) either the CalculateMetricBMI function or the CalculateUSBMI method gets called 
         */
        public double CheckMetricOrUS(Values values){

            if (values == Values.metric){
                return CalculateMetricBMI();
            }else if (values == Values.US){
                return CalculateUSBMI();
            }else{
                return 0;
            }

        }
        /*Calculates the BMI for a Metric Input, returns the calculated BMI */
        public double CalculateMetricBMI(){
            BMI = (weightReading / Math.Pow(heightReading,power));
            return BMI;
        }
        /*The CalculateUSBMI method Calculates the BMI for a American type Input*/
        public double CalculateUSBMI(){
            BMI = ((0.0703 * weightReading)/ (heightReading*heightReading));
            return BMI;
        }

        /*
        * The ShowBMIMessage methods functionality is to update the  weightCategory with the correct statement (Health range) for each of the computed BMIS
        * Returns a string with a statement which is then used in the MainForm class (ShowResultsForBMI() method) to show the user how healthy he or she is
        */
        public string showBMIMessage(){
            string stringOut = string.Empty;
            if (BMI >= 40){
                stringOut = "Obesity, Class III";
                return stringOut;
            }else if (BMI<=39.9&&BMI>=35.0){
                stringOut= "Obesity, Class II";
                return stringOut;
            }
            else if (BMI<= 34.9&&BMI>=30.0){
                stringOut = "Obesity, Class I";
                return stringOut;
            }
            else if (BMI<=29.9&&BMI>=25.0){
                stringOut = "Overweight(Pre-obesity)";
                return stringOut;
            } else if (BMI<=24.9&&BMI>=18.5){
                stringOut = "Normal weight";
                return stringOut;
            }
            else{
                stringOut = "Underweight";
                return stringOut;
            }
               
            
           
        }
        
    }
}
