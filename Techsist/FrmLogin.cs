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
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            if(login.doesLoginMatch(TxtEmail.Text, TxtPassword.Text))
            {
                FrmRegister Reg = new FrmRegister();
                Reg.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid Login! Try Again");
            }

        }
    }
}
