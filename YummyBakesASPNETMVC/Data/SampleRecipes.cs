using System;
using System.Collections.Generic;
using YummyBakesASPNETMVC.Models;

namespace YummyBakesASPNETMVC.Data
{
    public static class SampleRecipes
    {
        private static List<Recipe> _recipes;

        public static List<NutritionalFact> NutritionalFacts
        {
            get
            {
                List<NutritionalFact> nutritionFacts = new List<NutritionalFact>();
                nutritionFacts.Add(new NutritionalFact() { Name = "calories", Text = "240 calories" });
                nutritionFacts.Add(new NutritionalFact() { Name = "fatContent", Text = "9g fat" });
                return nutritionFacts;
            }
        }

        public static List<Review> Reviews
        {
            get
            {
                List<Review> reviews = new List<Review>();
                reviews.Add(new Review() { Rating = 5, Title = "Yum yum", Author = "A Reviewer", Body = "Thank you, great recipe!", DatePublished = DateTime.Now });
                reviews.Add(new Review() { Rating = 4, Title = "Delicious", Author = "A Reviewer", Body = "It makes me smile, it makes me happy eating it.", DatePublished = DateTime.Now });
                reviews.Add(new Review() { Rating = 5, Title = "Amazing", Author = "A Reviewer", Body = "This delivers on every... single ... level.", DatePublished = DateTime.Now });
                reviews.Add(new Review() { Rating = 3, Title = "Nice", Author = "A Reviewer", Body = "This is lovely, buttery perfection.", DatePublished = DateTime.Now });
                reviews.Add(new Review() { Rating = 5, Title = "Mmmmm", Author = "A Reviewer", Body = "Oh baby, that rocks!", DatePublished = DateTime.Now });
                return reviews;
            }
        }

        public static List<Recipe> Recipes
        {
            get
            {
                if (_recipes == null)
                {
                    var doughnut = CreateDoughnutRecipe();
                    var pumpkinpie = CreatePumpkinPieRecipe();
                    var swissroll = CreateSwissRollRecipe();
                    var croissant = CreateCroissantsRecipe();
                    var cupcake = CreateCupCakesRecipe();
                    _recipes = new List<Recipe>() { doughnut, pumpkinpie, swissroll, croissant, cupcake };
                }
                return _recipes;
            }
        }

        public static Recipe CreateDoughnutRecipe()
        {
            var recipe = new Recipe();
            recipe.Id = 1;
            recipe.Name = "Doughnuts";
            recipe.Author = "Homer Simpson";
            recipe.Description = "Go nuts for doughnuts with this mothwatering recipe.";
            recipe.PrepTime = "15 minutes";
            recipe.CookTime = "3 minutes";
            recipe.Yield = "6 doughnuts";
            recipe.NutritionalFacts = NutritionalFacts;

            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient() { Text = "Oil (for deep frying)" });
            ingredients.Add(new Ingredient() { Text = "2 cups sifted flour" });
            ingredients.Add(new Ingredient() { Text = "3 tablespoons sugar" });
            ingredients.Add(new Ingredient() { Text = "1 teaspoon nutmeg" });
            ingredients.Add(new Ingredient() { Text = "cup butter" });
            ingredients.Add(new Ingredient() { Text = "1 egg" });
            ingredients.Add(new Ingredient() { Text = "cup milk" });
            ingredients.Add(new Ingredient() { Text = "1/2 cup confectioners' sugar" });
            recipe.Ingredients = ingredients;

            List<Instruction> instructions = new List<Instruction>();
            instructions.Add(new Instruction() { Step = 1, Text = "Preheat oil to 375 degrees." });
            instructions.Add(new Instruction() { Step = 2, Text = "Combine flour, sugar, and nutmeg in bowl." });
            instructions.Add(new Instruction() { Step = 3, Text = "Cut butter with pastry blender or knives. Set aside." });
            instructions.Add(new Instruction() { Step = 4, Text = "Beat egg in measuring cup." });
            instructions.Add(new Instruction() { Step = 5, Text = "Add milk to measure 2/3 cup." });
            instructions.Add(new Instruction() { Step = 6, Text = "Add to flour mixture." });
            instructions.Add(new Instruction() { Step = 7, Text = "Stir with fork until blended." });
            instructions.Add(new Instruction() { Step = 8, Text = "Knead just until smooth." });
            instructions.Add(new Instruction() { Step = 9, Text = "Roll out to 1/2 inch thickness." });
            instructions.Add(new Instruction() { Step = 10, Text = "Cut out with floured doughnut cutter." });
            instructions.Add(new Instruction() { Step = 11, Text = "Deep fry 3 to 4 minutes." });
            instructions.Add(new Instruction() { Step = 12, Text = "Drain on paper towel." });
            instructions.Add(new Instruction() { Step = 13, Text = "Place confectioners' sugar in a bag." });
            instructions.Add(new Instruction() { Step = 14, Text = "Shake 2 doughnuts at a time to coat doughnuts." });
            recipe.Instructions = instructions;

            recipe.Reviews = Reviews;
            recipe.LargeImage = "doughnuts_128.png";
            recipe.Thumbnail = "doughnuts_48.png";
            recipe.FoodistaUrl = "http://www.foodista.com/recipe/MLX24CBP/quick-doughnuts";
            return recipe;
        }


        public static Recipe CreatePumpkinPieRecipe()
        {
            var recipe = new Recipe();
            recipe.Id = 2;
            recipe.Name = "Pumpkin Pie";
            recipe.Author = "Sheri Wetherell";
            recipe.Description = "Perfect for autumn when pumpkin is in season. This classic American recipe is sure to be a family favourite.";
            recipe.PrepTime = "15 minutes";
            recipe.CookTime = "55 minutes";
            recipe.Yield = "1 pie";
            recipe.NutritionalFacts = NutritionalFacts;

            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient() { Text = "1 (15 ounce) can pumpkin" });
            ingredients.Add(new Ingredient() { Text = "1 (14 ounce) can Sweetened Condensed Milk" });
            ingredients.Add(new Ingredient() { Text = "2 large eggs" });
            ingredients.Add(new Ingredient() { Text = "1 teaspoon ground cinnamon" });
            ingredients.Add(new Ingredient() { Text = "1/2 teaspoon ground ginger" });
            ingredients.Add(new Ingredient() { Text = "1/2 teaspoon ground nutmeg" });
            ingredients.Add(new Ingredient() { Text = "1/2 teaspoon salt" });
            ingredients.Add(new Ingredient() { Text = "1 (9 inch) unbaked pie crust" });
            ingredients.Add(new Ingredient() { Text = "Whipped cream for garnish" });
            recipe.Ingredients = ingredients;

            List<Instruction> instructions = new List<Instruction>();
            instructions.Add(new Instruction() { Step = 1, Text = "Preheat oven to 425 degrees F." });
            instructions.Add(new Instruction() { Step = 2, Text = "Whisk pumpkin, sweetened condensed milk, eggs, spices and salt in medium bowl until smooth. Pour into crust. Bake 15 minutes." });
            instructions.Add(new Instruction() { Step = 3, Text = "Reduce oven temperature to 350 degrees F and continue baking 35 to 40 minutes or until knife inserted 1 inch from crust comes out clean. Cool." });
            instructions.Add(new Instruction() { Step = 4, Text = "Garnish with whipped cream." });
            recipe.Instructions = instructions;

            recipe.Reviews = Reviews;
            recipe.LargeImage = "pumpkinpie_128.png";
            recipe.Thumbnail = "pumpkinpie_48.png";
            recipe.FoodistaUrl = "http://www.foodista.com/recipe/85C3ZDPN/classic-pumpkin-pie";
            return recipe;
        }

        public static Recipe CreateSwissRollRecipe()
        {
            var recipe = new Recipe();
            recipe.Id = 3;
            recipe.Name = "Swiss Roll";
            recipe.Author = "Swiss Tony";
            recipe.Description = "A timeless dessert. Lavish the sponge with your choice of cream and jam.";
            recipe.PrepTime = "15 minutes";
            recipe.CookTime = "20 minutes";
            recipe.Yield = "1 roll";
            recipe.NutritionalFacts = NutritionalFacts;

            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient() { Text = "1 cup flour, self-raising" });
            ingredients.Add(new Ingredient() { Text = "3 eggs" });
            ingredients.Add(new Ingredient() { Text = "cup sugar (caster)" });
            ingredients.Add(new Ingredient() { Text = "3 tablespoons boiling water" });
            ingredients.Add(new Ingredient() { Text = "cup raspberry jam" });
            ingredients.Add(new Ingredient() { Text = "sugar for dredging" });
            recipe.Ingredients = ingredients;

            List<Instruction> instructions = new List<Instruction>();
            instructions.Add(new Instruction() { Step = 1, Text = "Grease a 30cm X 25cm swiss roll tin, line with greaseproof paper and brush with melted butter. Set oven temperature to moderately hot (360F)." });
            instructions.Add(new Instruction() { Step = 2, Text = "Seperate Eggs." });
            instructions.Add(new Instruction() { Step = 3, Text = "In a clean bowl, beat egg whites until stiff, gradually add caster sugar, beating until sugar is dissolved and mixture is thick and glossy." });
            instructions.Add(new Instruction() { Step = 4, Text = "Add yolks and beat until combined. Sift all dry ingredients together, and gently fold into mixture. Spoon boiling water around edge of bowl and fold in." });
            instructions.Add(new Instruction() { Step = 5, Text = "Pour into prepared tin and shake gently into the corners. Bake for 10 minutes or until the cake springs back when lightly tapped with your finger." });
            instructions.Add(new Instruction() { Step = 6, Text = "Place jam in a saucepan and heat until it bubbles." });
            instructions.Add(new Instruction() { Step = 7, Text = "Have ready a sheet of greaseproof paper generously sprinkled with sugar and a sharp knife. Immediately when cake is cooked turn out onto the sugared paper." });
            instructions.Add(new Instruction() { Step = 8, Text = "Peel of the lining paper and cut off the crisp edges. Grasp the edge of the sugared paper and quickly roll up the cake in the paper, then unroll. Spread with the warm jam to within 2.5cm of the edges." });
            instructions.Add(new Instruction() { Step = 9, Text = "Reroll this time without the paper and sprinkle with more sugar if necessary. Stand on a cake cooler with the seam underneath until cold." });
            recipe.Instructions = instructions;

            recipe.Reviews = Reviews;
            recipe.LargeImage = "swissroll_128.png";
            recipe.Thumbnail = "swissroll_48.png";
            recipe.FoodistaUrl = "http://www.foodista.com/recipe/4RGT4QP5/swiss-roll";
            return recipe;
        }

        public static Recipe CreateCroissantsRecipe()
        {
            var recipe = new Recipe();
            recipe.Id = 4;
            recipe.Name = "Croissants";
            recipe.Author = "Helen Pitlick";
            recipe.Description = "Flaky and flavourful, these croissants will taste just like those from your local French bakery.";
            recipe.PrepTime = "30 minutes";
            recipe.CookTime = "20 minutes";
            recipe.Yield = "6 croissants";
            recipe.NutritionalFacts = NutritionalFacts;

            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient() { Text = "150 ml lukewarm water ( 1/2 cup)" });
            ingredients.Add(new Ingredient() { Text = "200 grams unsweetened partly-skimmed evaporated milk warmed (7oz)" });
            ingredients.Add(new Ingredient() { Text = "25 grams (1oz) Fresh yeast or 15g ( ½ oz) dried yeast" });
            ingredients.Add(new Ingredient() { Text = "50 grams unsalted butter, melted (2oz)" });
            ingredients.Add(new Ingredient() { Text = "500 grams granary flour (1lb)" });
            ingredients.Add(new Ingredient() { Text = "a pinch of salt" });
            ingredients.Add(new Ingredient() { Text = "75 grams margaine (3oz)" });
            ingredients.Add(new Ingredient() { Text = "milk, to glaze" });
            recipe.Ingredients = ingredients;

            List<Instruction> instructions = new List<Instruction>();
            instructions.Add(new Instruction() { Step = 1, Text = "Combine the water with the evaporated milk, and then crumble in the fresh yeast, or stir in the dried yeast. Add the butter. Sift the flour with the salt in a large bowl, returning the grains from the sieve to the flour in the bowl. Rub the margarine into the flour until the mixture resembles breadcrumbs." });
            instructions.Add(new Instruction() { Step = 2, Text = "Make a well in the center of the flour, pour in the yeast mixture and mix thoroughly. Turn the dough on to a lightly floured surface and knead for 3 minutes. Return the dough to the bowl, cover with a damp tea towel and leave to rise in a warm place for approximately 30 minutes until doubled in size." });
            instructions.Add(new Instruction() { Step = 3, Text = "Turn half of the risen dough on to a lightly floured surface and roll into a circle about 5mm ( 1/4 inch) thick. Using a sharp knife, cut the dough into eight triangular segments. Working from the outside edge, roll each segment into the middle. Bend each piece into a crescent and place on a lightly oiled baking sheet. Cover with a tea towel and leave to double in size." });
            instructions.Add(new Instruction() { Step = 4, Text = "Meanwhile preheat the oven to Gas Mark 5/190 C/375 F. Repeat the shaping process with the other half of the dough. Alternatively, leave the remaining dough covered in the refrigerator for up to 4 days and use when fresh croissants are required." });
            instructions.Add(new Instruction() { Step = 5, Text = "When the croissants have doubled in size, glaze them with the milk and bake in the oven for 15-20 minutes until puffed and golden." });
            recipe.Instructions = instructions;

            recipe.Reviews = Reviews;
            recipe.LargeImage = "croissants_128.png";
            recipe.Thumbnail = "croissants_48.png";
            recipe.FoodistaUrl = "http://www.foodista.com/recipe/BNQT5Z6V/granary-croissants";
            return recipe;
        }

        public static Recipe CreateCupCakesRecipe()
        {
            var recipe = new Recipe();
            recipe.Id = 5;
            recipe.Name = "Cup Cakes";
            recipe.Author = "Lori Zappala";
            recipe.Description = "These cupcakes are perfect for any occasion.";
            recipe.PrepTime = "30 minutes";
            recipe.CookTime = "20 minutes";
            recipe.Yield = "24 cupcakes";
            recipe.NutritionalFacts = NutritionalFacts;

            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient() { Text = "3/4 cup butter, softened" });
            ingredients.Add(new Ingredient() { Text = "1 1/2 cups granulated sugar" });
            ingredients.Add(new Ingredient() { Text = "3 eggs" });
            ingredients.Add(new Ingredient() { Text = "1 teaspoon coconut oil" });
            ingredients.Add(new Ingredient() { Text = "1 tablespoon vanilla" });
            ingredients.Add(new Ingredient() { Text = "1 teaspoon baking powder" });
            ingredients.Add(new Ingredient() { Text = "1/2 teaspoon baking soda" });
            ingredients.Add(new Ingredient() { Text = "1/2 teaspoon salt" });
            ingredients.Add(new Ingredient() { Text = "1 1/2 cups flour" });
            ingredients.Add(new Ingredient() { Text = "1/2 teaspoon red food coloring (optional)" });
            ingredients.Add(new Ingredient() { Text = "1/2 cup flaked baby coconut" });
            ingredients.Add(new Ingredient() { Text = "1 cup fresh cherries, pitted and chopped" });
            recipe.Ingredients = ingredients;

            List<Instruction> instructions = new List<Instruction>();
            instructions.Add(new Instruction() { Step = 1, Text = "Preheat oven to 350F." });
            instructions.Add(new Instruction() { Step = 2, Text = "Line a muffin pan with liners." });
            instructions.Add(new Instruction() { Step = 3, Text = "Butter and line with parchment a 9 inch round." });
            instructions.Add(new Instruction() { Step = 4, Text = "Cream the butter, coconut oil and the sugar, beat for about five minutes until light and fluffy." });
            instructions.Add(new Instruction() { Step = 5, Text = "Add eggs, one at a time, until fully incorporated." });
            instructions.Add(new Instruction() { Step = 6, Text = "Add vanilla extract and red food coloring." });
            instructions.Add(new Instruction() { Step = 7, Text = "Combine dry ingredients and add the dry mixture into the butter mixture very slowly (otherwise you will get a face full of flour)." });
            instructions.Add(new Instruction() { Step = 8, Text = "Add cherries and coconut, just mix until combined." });            
            recipe.Instructions = instructions;

            recipe.Reviews = Reviews;
            recipe.LargeImage = "cupcakes_128.png";
            recipe.Thumbnail = "cupcakes_48.png";
            recipe.FoodistaUrl = "http://www.foodista.com/recipe/LZMRCDCH/cherry-coconut-cupcakes";
            return recipe;
        }
    }
}