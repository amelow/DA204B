using System;

namespace Part2
{
    class MovieMain
    {
        public static void Main(string[] args){
            Movie movie = new Movie(); //creates a new movie object
            movie.ReadTitle();
            movie.ReadLength();
            movie.Convert();
            movie.ImdbRatings();
            movie.WouldRecommend();
            movie.DisplayInformation();
        }
    }
}
