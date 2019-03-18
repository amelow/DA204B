using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment3{
 
 /* The Third Assignment for the Introduction to C#(DA204B) course at the University of Malmö
  * Author: Amelie Löwe
  * Date: 2019-03-15
 */
    public class FuelCalculator{
       /*
       * Following class is the Fuel calculator class of the program. Its main task is to deal with the Fuel computations (gets requested by the MainForm class)
       * Also it tests the input of the user and calculates the result.
       */
        //Initializing my variables
        private double currReading;
        private double prevReading;
        private double fuelTankedReading;
        private double priceReading;
        private const double kmPerMile = 0.061371192;
        private const int sweMile = 10;
        //The enumeration types used in this class, a set of constants
        public enum Values{
            kmLiter,
            LiterKm,
            LiterMetric,
            LiterSwe
        }
        /*
         *The ValidateOdometerReading method verifies that the data of the Current Odometer Reading and the Previous Odometer Readings are correct.
         * Aka The Current Value cannot be smaller than the previous, as well as it cannot be smaller then zero.
         */
        public bool ValidateOdometerReading(){
            if (prevReading >= 0.0 && currReading >prevReading){
                return true;
            }
            else return false;
        }
        /*
         *The ValidateTheInputNumbers method checks if any of the input Fields in the Fuel Groupbox is negative (which it cannot be, only zero or bigger)
         */
        public bool ValidateTheInputNumbers(){
            if (currReading >= 0.0){
                return true;
            }
            else if (prevReading >= 0.0){
                return true;
            }
           else if (fuelTankedReading >= 0.0){
                return true;
            }
            else if (priceReading >= 0.0){
                return true;
                }
                else return false;
        }
        /*
        *Following method checks each value (enum) and calls upon the corresponding method for calculations
        */
        public double Calculate(Values values){
            if (values == Values.kmLiter){
                return CalcConsumptionKmPerLiter();
            }
            else if (values == Values.LiterKm){
                return CalcConsumptionLiterPerKm();
            }
            else if (values == Values.LiterMetric){
                return CalcConsumptionLiterPerMetricMile();
            }
            else if (values == Values.LiterSwe){
                return CalcLiterPerSweMil();

            }
            return 0;

        }
        /*Setter for the current odometer readings*/
        public void setCurrReading(double currReading){
            this.currReading = currReading;
            
        }
        /*Setter for the previous odometer readings*/
        public void setPrevReading(double prevReading){
            this.prevReading = prevReading;
           
        }
        /*Setter for Amount of fuel tanked*/
        public void setFuelTankedReading(double fuelTankedReading){
            this.fuelTankedReading = fuelTankedReading;
           
        }
        /*Setter for the Price method*/
        public void setPriceReading(double priceReading){
            this.priceReading = priceReading;
           
        }
        /*
         * Calculates the Fuel consumption for the Kilometer per LIter label
         */
        public double CalcConsumptionKmPerLiter(){
            return(currReading-prevReading)/fuelTankedReading; // need to compute the difference between current and prevoius firsy

        }
        /*
        * Calculates the Fuel consumption for Liter per Kilometer
        */
        public double CalcConsumptionLiterPerKm(){
            return fuelTankedReading/ (currReading - prevReading);

        }
        /*
         * Calculates the Fuel consumption for Liter per the Metric Mile
         */
        public double CalcConsumptionLiterPerMetricMile(){

            return CalcConsumptionLiterPerKm() / kmPerMile;
        }
        /*
         *  Following Calculates the Fuel consumption for Liter per the Swedish Mile
         */
        public double CalcLiterPerSweMil(){
            return CalcConsumptionLiterPerKm()*sweMile;

        }

        /*
         *  Following Calculates the Cost Per kilometer
         */
        public double CalcCostPerKm(){
            return CalcConsumptionLiterPerKm() * priceReading;
        }
      
    }
}
