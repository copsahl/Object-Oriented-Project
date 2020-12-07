using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Project
{
    public interface IRecipe
    {
        Recipe GetRecipeByName(List<Recipe> Recipes, string name);

        List<string> GetAllNotes(List<Note> NoteList);
    }
}
