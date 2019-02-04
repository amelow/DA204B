namespace DA204B
{
    public class Movie {
         private string title= " ";
         private double length = 0;
         //private int  oscarNominations = 0;
         //private int imdbRatings = 0;
         //private bool wouldRecommend = true;
         public string ReadTitle(){
         Console.WriteLine("What is the title of your favorite movie?");
         return title;
     }
     public double ReadLength(){
         Console.WriteLine("How long is "+ title+ " ?");
         return length;
     }
     
    }
    

}