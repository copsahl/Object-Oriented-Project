using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Project
{
    public class RecipeInterface
    {
        public Recipe GetRecipeByname(List<Recipe> Recipes, string name)
        {
            foreach(Recipe r in Recipes)
            {
                if(r.Name == name)
                {
                    return r;
                }
            }
            return null;
        }
    }
}
