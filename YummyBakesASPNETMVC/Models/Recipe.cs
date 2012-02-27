using System.Collections.Generic;

namespace YummyBakesASPNETMVC.Models
{
    public class Recipe
    {
        public Recipe()
        {
            NutritionalFacts = new List<NutritionalFact>();
            Ingredients = new List<Ingredient>();
            Instructions = new List<Instruction>();
            Reviews = new List<Review>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }        
        public string Thumbnail { get; set; }
        public string LargeImage { get; set; }
        public string Description { get; set; }

        public string PrepTime { get; set; }
        public string CookTime { get; set; }
        public string Yield { get; set; }

        public string FoodistaUrl { get; set; }

        public List<NutritionalFact> NutritionalFacts { get; set; }

        public List<Ingredient> Ingredients { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Instruction> Instructions { get; set; }
    }
}