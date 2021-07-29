using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage
{
    class User
    { 
         public string name;
         public string password;
         public string email;
        public User (string name,string password,string email)
        {
            this.name = name;
            this.password = password;
            this.email = email;
        }
        public string getInfo()
        {
            return "User : { name " + name + " password " + password + " email " + email;
        }
    }
}
