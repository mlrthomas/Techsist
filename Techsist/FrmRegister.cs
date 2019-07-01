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
            GrpSARadio.Hide();
            LblPosition.Hide();
            TxtPosition.Hide();
        }

        private void LblHaveAccount_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Visible = false;
            login.Show();
        }

        private void CboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblPosition.Show();
            if (CboDepartment.Text == "System Administrator")
            {
                TxtPosition.Hide();
                GrpSARadio.Show();
            }else {
                TxtPosition.Show();
                GrpSARadio.Hide();
            }
        }
    }
}
