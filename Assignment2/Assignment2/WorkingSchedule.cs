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
        private void ShowProgramInfo(){
            Console.WriteLine("\n\n +++++++++ Working Schedule +++++++++");
            Console.WriteLine("\n                                      \n");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++\t");
        }
       /*
       * Method for reading the users input, then        
       */
        private void ReadInput(){
           if (menuInput == ChoiceNights){
           DisplayInfo(firstWeekSix, lastWeek, fiftWeek);
            }else if (menuInput == choiceWeekends){
                DisplayInfo(firstWeekOne, lastWeek, thirdWeek);
            }
        }
        private void DisplayInfo(int start, int end, int frequency){
            if(start== 6){
                Console.WriteLine("You are going to work nights on following weeks:  ");
            }else if(start == 1){
                Console.WriteLine("You are going to work weekends on following weeks:  ");
            }

            for (int i = start; i < end; i += frequency){
                Console.Write("Week" + i + "\n ");
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++\t");
        }
    }
}
