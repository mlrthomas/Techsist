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
    public partial class FrmLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maria\source\repos\Techsist\Techsist\TechsistDatabase.mdf;Integrated Security=True");

        public FrmLogin()
        {
            InitializeComponent();
            TxtPassword.PasswordChar = '*';
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Query query = new Query();

            if (login.doesLoginMatch(TxtEmail.Text, TxtPassword.Text))
            {
                if(query.GetDepartment(TxtEmail.Text) == "System Administrator"){
                    FrmSaUser SaUser = new FrmSaUser();
                    SaUser.Show();
                    this.Visible = false;
                }
                else
                {
                    FrmRegularUser RegUser = new FrmRegularUser();
                    RegUser.Show();
                    this.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Invalid Login! Try Again");
            }



        }

        private void LblRegisterNow_Click(object sender, EventArgs e)
        {
            FrmRegister RegNewUser = new FrmRegister();
            RegNewUser.Show();
            this.Visible = false;
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
