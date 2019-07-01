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
    public partial class FrmRegister : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maria\source\repos\Techsist\Techsist\TechsistDatabase.mdf;Integrated Security=True");

        public FrmRegister()
        {
            InitializeComponent();
            GrpSARadio.Hide();
            LblPosition.Hide();
            TxtPosition.Hide();
        }
        FrmLogin login = new FrmLogin();
        private void LblHaveAccount_Click(object sender, EventArgs e)
        {
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

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            User newUser = new User();
            DateTime now = DateTime.Now;
            newUser.FirstName = TxtFirstName.Text;
            newUser.LastName = TxtLastName.Text;
            newUser.Email = TxtEmail.Text;
            newUser.Password = TxtPassword.Text;
            newUser.Department = CboDepartment.Text;
            if (CboDepartment.Text == "System Administrator")
            {
                if (RdoSALead.Checked)
                {
                    newUser.Position = RdoSALead.Text;
                    newUser.Permission = 2;
                }
                else
                {
                    newUser.Position = RdoSA.Text;
                    newUser.Permission = 1;
                }
            }
            else
            {
                newUser.Position = TxtPosition.Text;
                newUser.Permission = 0;
            }

            newUser.CreationDate = now;
            dc.Users.InsertOnSubmit(newUser);
            dc.SubmitChanges();
            MessageBox.Show("Successfully Registered");
            this.Visible = false;
            login.Show();
        }

     
    }
}
