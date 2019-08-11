using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Techsist
{
    //Start of the Login Form
    public partial class FrmLogin : Form
    {
        //Established the Connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maria\source\repos\Techsist\Techsist\TechsistDatabase.mdf;Integrated Security=True");

        public FrmLogin()
        {
            InitializeComponent();
            TxtPassword.PasswordChar = '*'; // Masks the Password
        }

        //Button for Sign-In
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Query query = new Query();
            int queryId = query.GetUserId(TxtEmail.Text);
            //Verifies if login matched
            if (login.doesLoginMatch(TxtEmail.Text, TxtPassword.Text))
            {
                //Verifies if user is regular or system administrator
                if(query.GetDepartment(TxtEmail.Text) == "System Administrator"){
                    FrmSaUser SaUser = new FrmSaUser(queryId);
                    SaUser.Show();
                    this.Visible = false;
                }
                else
                {
                    FrmRegularUser RegUser = new FrmRegularUser(queryId);
                    RegUser.Show();
                    this.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Invalid Login! Try Again");
            }
        }

        //RegisterButton Function
        private void LblRegisterNow_Click(object sender, EventArgs e)
        {
            FrmRegister RegNewUser = new FrmRegister();
            RegNewUser.Show();
            this.Visible = false;
        }

        //Exit Icon that close the application
        private void LblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
