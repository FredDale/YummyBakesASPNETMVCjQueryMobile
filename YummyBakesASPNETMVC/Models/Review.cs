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
    }    
}