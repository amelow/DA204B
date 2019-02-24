using System;
namespace Assignment2
{
    /*
     * Second assignment for the Introduction to C#(DA204B) course at the University of Malmö.
     * Author: Amelie Löwe
     * Date: 2019-02-18. 
     */
    public class WorkingScheduleMenu
    {
        /*
         * Following class is complementary to the WorkingSchedule class.
         * Task description is found in that class.        
         */

        private bool isWorkMenu = true;
        private int menuInput;

        public void Start()
        {
            while (isWorkMenu)
            {
                DisplayMenu();
                ReadInputandSendInfo();
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine("\n Select from the menu which type of schedule you want to see\n");
            Console.WriteLine("To Show a list of the nights to work, press 1");
            Console.WriteLine("To Show a list of the weekends to work, press 2");
            Console.WriteLine("To return to main menu, press 0");
        }
        private void ReadInputandSendInfo()
        {
            Console.Write("\n Which one do you want to see? : ");
            menuInput = Input.ReadIntegerConsole();
            Console.Write("\n You chose number: " + menuInput);

            if ((menuInput == 1 || menuInput == 2))
            {
                WorkingSchedule workingSchedule = new WorkingSchedule(menuInput);
                workingSchedule.Start();
            }
            else if (menuInput == 0)
            {
                isWorkMenu = false;
                Console.Write("\n Okay im taking you back to the main menu \n ");
            }
        }
    }
}