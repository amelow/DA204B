using System;
namespace Assignment2{
/*
 * Second assignment for the Introduction to C#(DA204B) course at the University of Malmö.
 * Author: Amelie Löwe
 * Date: 2019-02-24. 
 */
    public class WorkingSchedule{
     

        private int choiceWeekends = 1;
        private int ChoiceNights = 2;
        private int firstWeekOne = 1;
        private int firstWeekSix = 6;
        private int lastWeek = 52;
        private int thirdWeek= 3;
        private int fiftWeek= 5;
        private int menuInput;
       
        /*
         * Constructor for the workingschedule class       
         */
      public WorkingSchedule(int menuInput){ // menu choice from the workingschedulemenu class
            this.menuInput = menuInput;
        }

       /*
       * Method that calls all of the other mehods used in this class    
       */
        public void Start(){
            Console.WriteLine("In Working Schedule Class ");
            ShowProgramInfo();
            ReadInput();
          }
       /*
        * Basically showing a header for the WorkingSchedule class
        */
        private void ShowProgramInfo(){
            Console.WriteLine("\n\n +++++++++ Working Schedule +++++++++");
            Console.WriteLine("\n                                      \n");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++\t");
        }
        /*
        * Method for reading the users input, then depending on the users choice,
        * different parameters will be sent into the DisplayInfo() method.
        * If number 1 is pressed, the weeks start at 6 and only work nights.
        * If the number 2 is pressed, the weeks start at 1 and you will work weekends       
        */
        private void ReadInput(){
           if (menuInput == ChoiceNights){
           DisplayInfo(firstWeekSix, lastWeek, fiftWeek);
            }else if (menuInput == choiceWeekends){
                DisplayInfo(firstWeekOne, lastWeek, thirdWeek);
            }
        }
       /*
        * Displaying the working weeks. This is done by looping thru all weeks with a frequency,
        * depending on the chosen number in the previous  method. I chose this kind of loop since this 
        * is the most easiest one for me since i have a start and already know how many iteration it is suppose to take.
        * Also it makes it simple to print the week in every iteration 
        */
        private void DisplayInfo(int start, int end, int frequency){
            if(start== 6){
                Console.WriteLine("You are going to work nights on following weeks:  ");
            }else if(start == 1){
                Console.WriteLine("You are going to work weekends on following weeks:  ");
            }

            for (int i = start; i <= end; i += frequency){
                Console.Write("Week" + i + "\n ");
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++\t");
        }
    }
}
