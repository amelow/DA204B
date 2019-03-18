using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Assignment3 {

    /* The Third Assignment for the Introduction to C#(DA204B) course at the University of Malmö
     * Author: Amelie Löwe
     * Date: 2019-03-15
     */
    public partial class MainForm : Form {
        /*
         * Following class is the "main class" of the program. Its main task is to present the options for 2 different calculators. 
         * As well as handeling the button functions, and presenting Input options and Results
         */

        //Declares and creates an instance of the Fuel Calculator
        private FuelCalculator fuelCalc = new FuelCalculator();
        //Declares and creates an instance of the BMI Calculator
        private BMICalculator bmiCalc = new BMICalculator();
        private string name = String.Empty;
        private double value = 0;
        /*
         * MainForm is the constructor of this class. 
         * Is automatically written by VS 
         * Is executed when the object of MainForm is created
         */
        public MainForm() {
            InitializeComponent();
            InitializeGUI();
        }
        /*
         * Following method initializes the GUI,and calls upon the clearFields method.
         * It also has some default values, I choose for example The American Unit to be set as standard
         */
        private void InitializeGUI() {
            heightLabel.Text = "Height (inches)";
            weightLabel.Text = "Weight (lbs)";
            USRadioBtn.Checked = true;
            clearAllFields();
        }
        /*
         * Following method Calls upon the 4 other methods for clearing the fields of 
         * the windows application
         */
        private void clearAllFields() {
            clearBMIInputInformation();
            clearFuelInputInformation();
            clearBMIOutputInformation();
            clearFuelOutputInformation();

        }
        /*
         * The clearBMIInputInformation sets all of the BMI input fields to be empty.
         * So that the name, weight and height input textboxes are cleared before usage
         */
        private void clearBMIInputInformation() {
            nameTextBox.Text = String.Empty;
            heightTextBox.Text = String.Empty;
            weightTextBox.Text = String.Empty;

        }
        /*
        * The clearFuelInputInformation sets all of the Fuel input fields in the program to be empty.
        * ex Current Odometer Reading Textbox should be cleared 
        */
        private void clearFuelInputInformation() {
            currOdometerTextBox.Text = String.Empty;
            prevOdometerTextBox.Text = String.Empty;
            currFuelTankedTextBox.Text = String.Empty;
            pricePerLitTextBox.Text = String.Empty;

        }
       /*
       * This Methods main responisbility is clearing the result labels of the BMI fields  
       */
        private void clearBMIOutputInformation(){
            yourBMIResultLabel.Text = String.Empty;
            weightCategoryResultLabel.Text = String.Empty;


        }
        /*
         * This Methods main responisbility is clearing the result labels of the FuelCalculator fields  
         */
        private void clearFuelOutputInformation(){
            fuelConKmResultLabel.Text = String.Empty;
            fuelConMetricResultLabel.Text = String.Empty;
            fuelConMetricLabel.Text = String.Empty;
            fuelConSweResultLabel.Text = String.Empty;
            costPerKmResultLabel.Text = String.Empty;
        }
        /*
         * This BMICalcBtn_Click method handles the functionality of the BMI button when clicked.
         * Then validates the input of the user, if it is wrong a messagebox with a warning is displayed.
         * Following method also calls upon the readName() method to get the users name, then when everything is calculated it calls the ShowResultsForBMI(),
         * To print the right results in the corresponding result label fields.
         */
        private void BMICalcBtn_Click(object sender, EventArgs e) {
            if (ReadInputBMI()) { // Read input method for BMI
                Console.WriteLine("Check if input valid");
                if (!bmiCalc.ValidateInput(double.Parse(heightTextBox.Text), double.Parse(weightTextBox.Text))) { 
                    MessageBox.Show("Height and Weight input cannot be negative or 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                readName(); // reads users name
                if (metricRadioBtn.Checked) { // Checks the Radio Buttons, if either The Metric or the American values are clicked
                    bmiCalc.CheckMetricOrUS(BMICalculator.Values.metric); // calculates BMI in Metric- unit
                } else if (USRadioBtn.Checked) {
                    bmiCalc.CheckMetricOrUS(BMICalculator.Values.US); // calculates BMI in US- unit
                }
                ShowResultsForBMI(); // Method for displaying the results
            }
           
        }
       /*
      * This Methods handles the users Name field input 
      */
        private string readName() {
           name = nameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(nameTextBox.Text)) { // Checks if field is empty
                name = " NO NAME"; // difault if no name given
            }
            else {
               bmiCalc.setName(name); // sets the name of the input field as the name variable and returns it
            }
            return name;
        }
        /*
        * This fuelcalcBtn_Click method handles the functionality of the Fuel button when clicked.
        * Then validates the input of the user, if it is wrong a messagebox with a warning is displayed.
        * Then when everything is correct,  different calculations occur in the FuelCalculator class,followes by a call for the ShowResultsForBMI() method,
        * To print the right results in the corresponding Fuel result fields.
        */
        private void fuelcalcBtn_Click(object sender, EventArgs e) {
            bool works = ReadInputFuel();
            if (works) {
                if (fuelCalc.ValidateTheInputNumbers()) { // checks if inputs are 0 or negative numbers
                    if (fuelCalc.ValidateOdometerReading()) { // checks the Odometer inputs
                        ShowResultsForFuel(); // updates the Fuel labels with correct Results
                    }
                    else {
                        MessageBox.Show("The Current Odometer input cannot be smaller than the Previous Odometer reading", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else {
                    MessageBox.Show("The Fuel inputs cannot be negative numbers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        /*
         * The ReadInputBMI method checks whether the BMI calculator should use the US or the Metric unit as parameters for the setters in the BMI calculator class.
         * Also for the Metric unit the input value gets converted from meters to centimers, as well as the American that gets converted from feet to inches
         */
        private bool ReadInputBMI(){
            //Read the height input field
            value = 0;
            if(double.TryParse(heightTextBox.Text, out value)){
                if (bmiCalc.getValues() == BMICalculator.Values.US){
                     value = (value * 12); // convert to inches
                    bmiCalc.setHeight(value);
                }
                else{
                    value = value / 100; // convert to meters
                    bmiCalc.setHeight(value);
                }
            }
            else return false;
            // Read the weight Input field
            value = 0;
            if (double.TryParse(weightTextBox.Text, out value)){
                System.Console.WriteLine(value);
                bmiCalc.setWeight(value);
            }
            else return false;
            return true;

        }
        /*
         * The ReadInputFuel method reads the users input in each fiels and sets(gets sent as parameters to the setters and getters in the Fuel Calculator class) the values.
         */
        private bool ReadInputFuel(){
            //Read current input field
            value = 0;
            if (double.TryParse(currOdometerTextBox.Text, out value)) {
                System.Console.WriteLine(value);
                fuelCalc.setCurrReading(value);
            }
            else return false;
            //Read prevous input field
            value = 0;
            if (double.TryParse(prevOdometerTextBox.Text, out value)) {
                fuelCalc.setPrevReading(value);
            }
            else return false;
            //Read FuelTanked input field
            value = 0;
            if (double.TryParse(currFuelTankedTextBox.Text, out value)){
                fuelCalc.setFuelTankedReading(value);
            }
            else return false;
            //Read pricePerLiter input field
            value = 0;
            if (double.TryParse(pricePerLitTextBox.Text, out value)){
                fuelCalc.setPriceReading(value);
            }
            else return false;

            return true;
        }
        /*
         * Following method simply changes the empty result fields of the FuelCalculator to the correct outputs. This is done by performing different calculations,
         * depending on the Fuel input fields data
         * I choose to round of the result with three decimals to accurately show the result.
         */
        private void ShowResultsForFuel() { 
            fuelConKmResultLabel.Text = fuelCalc.Calculate(FuelCalculator.Values.kmLiter).ToString("0.000");
            fuelConMetricResultLabel.Text = fuelCalc.Calculate(FuelCalculator.Values.LiterKm).ToString("0.000");
            fuelConMetricLabel.Text = fuelCalc.Calculate(FuelCalculator.Values.LiterMetric).ToString("0.000");
            fuelConSweResultLabel.Text = fuelCalc.Calculate(FuelCalculator.Values.LiterSwe).ToString("0.000");
            costPerKmResultLabel.Text = fuelCalc.CalcCostPerKm().ToString("0.000");
        }
        /*
        * Following method simply changes the empty result fields to the correct outputs. This is done by performing different calculations, depending on the BMI input fields data
        * I choose to round of the result with three decimals to accurately show the result.
        * Also the GroupBox is updated to the users name if given. Otherwise No Name will be printed.
        */
        private void ShowResultsForBMI(){
            groupBox4.Text = "Result for : " + bmiCalc.getName(); 
            Console.WriteLine(bmiCalc.getBMI().ToString("0.000"));
            yourBMIResultLabel.Text = bmiCalc.getBMI().ToString("0.000");
            weightCategoryResultLabel.Text = bmiCalc.showBMIMessage();

        }
        /*
        * Following method handles the functionality of a RadioButton.
        * When the Metric(cm,kg) button is clicked the height and weight labels should be updated with the correct unit
        */
        private void metricRadioBtn_CheckedChanged(object sender, EventArgs e){
            heightLabel.Text = "Height (cm)";
            weightLabel.Text = "Weight (kg)";
        }
        /*
         * Following method handles the functionality of a RadioButton.
         * When the  US(Inch,lbs) button is clicked the height and weight labels should be updated with the correct unit
         */
        private void USRadioBtn_CheckedChanged(object sender, EventArgs e){
            heightLabel.Text = "Height (Inch)";
            weightLabel.Text = "Weight (lbs)";
        }
       /*
      * Clears all fields in the program if the "Clear" button is pressed
      */
        private void ClearAll_Click(object sender, EventArgs e){
            clearAllFields();
        }
    }
 }
