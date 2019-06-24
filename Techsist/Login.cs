using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techsist
{
    // Start of Login Class
    public class Login
    {
        // EmptyConstructor
        public Login() { }

        // Getter Setter for login variables
        private string UserName { get; set; } = "";
        private string Password { get; set; } = "";

        // Assigned temporary username and password as administrator
        public string User = "admin@hotmail.com";
        public string RegUser = "regularuser@hotmail.com";
        public string Pass = "password";

        //Check if user input match to the login
        public bool doesLoginMatch(string UserName, string Password)
        {
            if ((UserName == User && Password == Pass) || (UserName == RegUser && Password == Pass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }//End of Login Class
}
