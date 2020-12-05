using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Project
{
    public interface IUserRepo
    {
        bool Login(string Username, string password);
        List<User> GetAll();
        User GetUserByName(List<User> UserList, string Username);

    }
}
