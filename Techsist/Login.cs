using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techsist
{
    // Start of Login Class
    public class Login
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maria\source\repos\Techsist\Techsist\TechsistDatabase.mdf;Integrated Security=True");
        
        // EmptyConstructor
        public Login() { }

        // Getter Setter for login variables
        private string UserName { get; set; } = "";
        private string Password { get; set; } = "";

        //Check if user input match to the login
        public bool doesLoginMatch(string UserName, string Password)
        {

            Query query = new Query();
            string queryPassword = query.GetPassword(UserName);
            if (Password == queryPassword)
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
