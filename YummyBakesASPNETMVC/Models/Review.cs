using System;

namespace YummyBakesASPNETMVC.Models
{
    public class Review
    {        
        public int Rating { get; set; }
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DatePublished { get; set; }
        public string Body { get; set; }
        public string RatingText
        {
            get { return HtmlHelper.ConvertRatingToText(Rating); }
        }
    }

    public class HtmlHelper
    {
        public static string ConvertRatingToText(int rating)
        {
            string ratingText = "";
            switch (rating)
            {
                case 1:
                    ratingText =  "one";
                    break;
                case 2:
                    ratingText = "two";
                    break;
                case 3:
                    ratingText = "three";
                    break;
                case 4:
                    ratingText = "four";
                    break;
                case 5:
                    ratingText = "five";
                    break;               
            }
            return ratingText;
        }
    }
}