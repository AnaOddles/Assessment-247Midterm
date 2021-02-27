using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_247.Models
{
    public class AssessmentModel
    {
        //C;ass properties with display names for model in form 
        [Display(Name = "Enter your name")]
        public string Name { get; set; }
        [Display(Name = "Enter the calories")]
        public string Calories { get; set; }

        [Display(Name = "Enter the Ingredient #1")]
        public string IngredientOne { get; set; }

        [Display(Name = "Enter the Ingredient #2")]
        public string IngredientTwo { get; set; }
    }
}
