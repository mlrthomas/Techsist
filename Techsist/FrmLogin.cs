using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Techsist
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            TxtPassword.PasswordChar = '*';
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            if(login.doesLoginMatch(TxtEmail.Text, TxtPassword.Text))
            {
                if(TxtEmail.Text == login.RegUser )
                { 
                    FrmRegularUser RegUser = new FrmRegularUser();
                    RegUser.Show();
                    this.Visible = false;
                }
                else
                {
                    FrmSaUser SaUser = new FrmSaUser();
                    SaUser.Show();
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
    }
}
