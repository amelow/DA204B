using System;
using System.Diagnostics;
/*
 * First assignment for the Introduction to C#(DA204B) course at the University of Malmö.
 * The exercise was to find a object in my house and write descriptive methods for it.
 * Author: Amelie Löwe
 * Date: 2019-02-06. 
 */

namespace Part2{
    public class Movie{
        /*Declaring all variables*/
        private string title = " ";
        private int length = 0;
        private double imdbRatings = 0;
        private bool wouldRecommend = true;
        private int hour;
        private int minutes;
        private int seconds;

        /*Method for getting the movie title*/
        public string ReadTitle(){
            Console.WriteLine("Greetings from the Movie Object! :)"+ "\n-----------");
            Console.WriteLine("What is the title of the latest movie you watched?");
            title = Console.ReadLine();
            Console.WriteLine(title);
            return title;
        }
        /*Method for getting the length of the movie*/
        public int ReadLength(){
            Console.WriteLine("How long is " + title + " ? Please give it in seconds!");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine(length);
            return length;
           
        }
        /*Method for processing and converting the previous methods information*/
        public void Convert(){
            length = length % (24 * 3600);
            hour = length / 3600;

            length %= 3600;
            minutes = length / 60;

            length %= 60;
            seconds = length;
        }
        /*Method for rating the movie*/
        public double ImdbRatings(){
            Console.WriteLine("Give the score out of /10 ");
            imdbRatings = double.Parse(Console.ReadLine());
            Console.WriteLine(imdbRatings);
            return imdbRatings;
        }
        /*Method for recommending the movie to anyone*/
        public bool WouldRecommend(){
            Console.WriteLine("Would you recommend this movie, answer with yes or no!");
            string checkYesOrNo = Console.ReadLine();
            if (checkYesOrNo == "yes" || checkYesOrNo == "Yes")
            {
                Console.WriteLine("Fetching Answer -OK" + "\n-----------");
                return true;
            }
            else if (checkYesOrNo == "no" || checkYesOrNo == "No")
            {
                Console.WriteLine("Fetching Answer -OK" + "\n-----------");
                return wouldRecommend = false;
            }
            else
            {
                Console.WriteLine("Please answer with only Yes or No");
               
            }
            return wouldRecommend = false;
        }
        /*Method for displaying the users infomation about the movie */
        public void DisplayInformation(){
        Console.WriteLine("The Movie information"+"\n-----------");
        Console.WriteLine("Movie: "+ title);
        Console.WriteLine(title+ " is " + hour + "h, " + minutes + " min, " + seconds + " sec,long!");
        Console.WriteLine("You rated this movie "+ imdbRatings+ "/10");
        if (wouldRecommend)
                Console.WriteLine("You would recommend "+ title);
            else
                Console.WriteLine("You would not recommend "+ title);



        }
    }
}