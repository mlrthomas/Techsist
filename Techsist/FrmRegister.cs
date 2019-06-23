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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void LblHaveAccount_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Visible = false;
            login.Show();
        }
    }
}
