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
        private int firstWeekSix = 1;
        private int lastWeek = 52;
        private int thirdWeek= 3;
        private int fiftWeek= 5;
        private int menuInput;

        public void  Start(){
            ShowProgramInfo();
            ReadInput();

          }
        private void ShowProgramInfo(){
            Console.WriteLine("\n\n +++++++++ Working Schedule +++++++++");
            Console.WriteLine("\n                                      \n");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++\t");
        }
        private void ReadInput(){
            if (menuInput == choiceWeekends){
                DisplayInfo(firstWeekOne, lastWeek, thirdWeek);
          } else if (menuInput==ChoiceNights){
                DisplayInfo(firstWeekSix, lastWeek,)

            }
        }
        private void DisplayInfo(int start, int end, int frequency){
        }
    }
}
