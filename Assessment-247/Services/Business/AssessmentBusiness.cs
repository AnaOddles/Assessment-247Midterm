using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_247.Models;

namespace Assessment_247.Services.Business
{
    public class AssessmentBusiness
    {
        //Assessmentmodel obj
        public AssessmentModel model { get; set; }

        //Constructor passing in the assementmodel 
        public AssessmentBusiness(AssessmentModel model)
        {
            this.model = model;
        }

        //Function to reverse the ingridnets 
        public void Reverse()
        {
            this.model.IngredientOne = ReverseWords(this.model.IngredientOne);
            this.model.IngredientTwo = ReverseWords(this.model.IngredientTwo);

        }

        //Helper function to reverse usisn char arrays
        public string ReverseWords(string word)
        {
            char[] arrayWord = word.ToCharArray();
            Array.Reverse(arrayWord);
            return new string(arrayWord);
        }
    }
}
