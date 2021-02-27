using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_247.Models;
using Assessment_247.Services.Business;

namespace Assessment_247.Controllers.Assessment
{
    public class AssessmentController : Controller
    {
        //GET for the Menu View
        public IActionResult Menu()
        {
            return View("Menu");
        }

        //POST for the reversing - with passed in ASP model 

        [HttpPost]
        public IActionResult Assessment(AssessmentModel model)
        {
            //WE DO NOT NEED TO INSTANTATE THE MODEL SINCE WE PASSING 
            //IT IN FROM THE FORM 

            //Create new instance of Business 
            AssessmentBusiness business = new AssessmentBusiness(model);

            //Reverse the words with the business service 
            business.Reverse();

            ViewBag.FirstIngredient = business.model.IngredientOne;
            ViewBag.SecondIngredient = business.model.IngredientTwo;


            return View("Menu");
        }
    }
}
