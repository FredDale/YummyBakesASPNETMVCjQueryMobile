using System;
using System.Linq;
using System.Web.Mvc;
using YummyBakesASPNETMVC.Data;
using YummyBakesASPNETMVC.Models;

namespace YummyBakesASPNETMVC.Controllers
{
    public class RecipeController : YummyBakesBaseController
    {
        public ActionResult Index()
        {
            return View(SampleRecipes.Recipes.Take(3).ToList());
        }

        public ActionResult Details(int id)
        {
            ViewBag.PageId = "recipe-details";
            return View(SampleRecipes.Recipes.Single(r => r.Id == id));
        }

        public ActionResult Find()
        {
            return View(SampleRecipes.Recipes);
        }

        public ActionResult AddReview(Review review)
        {
            review.DatePublished = DateTime.Now;                        
            //SampleRecipes.Recipes.Single(r => r.Id == review.RecipeId).Reviews.Add(review);
            return Content(RenderPartialViewToString("Review", review));
        }
    }
}
