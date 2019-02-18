using System;
namespace Assignment2{
/*
 * Second assignment for the Introduction to C#(DA204B) course at the University of Malmö.
 * Author: Amelie Löwe
 * Date: 2019-02-18. 
 */
    public class Input{
        /*
        * This class is meant to be a helper class.
        * Containing shared methods for converting string expression to their corresponding numeric numbers.
        */

        public static int ReadIntegerConsole() {
            int number;

            if (int.TryParse(Console.ReadLine(),out number))
                return number;
            else
                Console.WriteLine("Wrong input, please try again!");
            return ReadIntegerConsole();

        }
        public static double ReadDoubleConsole(){
            double number;
            if (double.TryParse(Console.ReadLine(), out number))
                return number;
            else
                Console.WriteLine("Wrong input, please try again!");
            return ReadDoubleConsole();
        }
    }
}
