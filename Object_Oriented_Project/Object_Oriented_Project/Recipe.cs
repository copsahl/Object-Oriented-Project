using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Project
{
    public class Recipe
    {
        public string Name { get; set; }
        public string RoastUsed { get; set; }
        public string CreamerUsed { get; set; }

        public Note RecipeNotes { get; set; }
    }
}
