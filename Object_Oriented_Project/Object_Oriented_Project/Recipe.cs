using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Project
{
    public class Recipe
    {
        public int UserIdAssociation { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public Roast RoastUsed { get; set; }

        public Note RecipeNotes { get; set; }
    }
}
