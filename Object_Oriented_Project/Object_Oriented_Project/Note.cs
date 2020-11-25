using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Project
{
    public class Note
    {
        public int AssociatedRecipeId { get; set; }
        public string Name { get; set; }
        public List<string> RecipeNotes { get; set; }
    }
}
