using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Project
{
    public class UserRepo : IUserRepo
    {
        private List<User> _Users = new List<User>();

        public UserRepo()
        {
            Roast roast1 = new Roast { Bean = "Buenos Aires Maracaturra", RoastTimeMinutes = 8, RoastAmountCups = 1, CountryOfOrigin = "Nicaragua", RoastCoolMinutes = 20 };
            Roast roast2 = new Roast { Bean = "El Diamante Don Elvis", RoastTimeMinutes = 8, RoastAmountCups = 1, CountryOfOrigin = "Peru", RoastCoolMinutes = 15 };
            _Users.Add(new User { Id = 1, Name = "Chase", Password = "Hello", UserRoasts = new List<Roast> { roast1 }, UserRecipes = new List<Recipe> { new Recipe { Name = "Super Mega Dope", RoastUsed = roast1.Bean, CreamerUsed = "None", RecipeNotes = new Note { AssociatedRecipeId = 1, Name = "Test Note", RecipeNotes = new List<string>{"Mmmmm. That's pretty good!"} } } } });
            _Users.Add(item: new User { Id = 2, Name = "Jason", Password = "Hello", UserRoasts = new List<Roast> { roast2 }, UserRecipes = new List<Recipe> { new Recipe { Name = "Super Mega Dope", RoastUsed = roast2.Bean, CreamerUsed = "French Vanilla", RecipeNotes = new Note { AssociatedRecipeId = 1, Name = "Test Note", RecipeNotes = new List<string> { "Wowza, tastes yummy!" } } } } });
        }

        public bool Login(string Username, string password)
        {
            foreach(User u in _Users){
                if(u.Name == Username && u.Password == password)
                {
                    u.LoggedIn = true;
                    return true;
                }
            }
            return false;
        }

        public List<User> GetAll()
        {
            return _Users;
        }
        
        public User GetUserByName(List<User> UserList, string Username)
        {
            foreach (User u in UserList)
            {
                if (u.Name == Username)
                {
                    return u;
                }
            }
            return null;
        }
    }
}
