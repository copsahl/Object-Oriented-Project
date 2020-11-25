using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Project
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // I know this is far from best practice but I'm doing this for Proof of Concept
        // because I don't want to have to integrate reading and writing from files just yet. 
        public string Password { get; set; }
    }
}
