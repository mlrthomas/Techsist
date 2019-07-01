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
    public partial class FrmSaUser : Form
    {
        SqlConnection con = new SqlConnection(Techsist.Properties.Settings.Default.TechsistDatabaseConnectionString);
        public FrmSaUser()
        {
            InitializeComponent();
        }

        private void FrmSaUser_Load(object sender, EventArgs e)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var selectQuery = 
                                from a in dc.GetTable<User>()
                                select a;
            DgvUserList.DataSource = selectQuery;
            
        }

        private void LblLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLogin Log = new FrmLogin();
            Log.Show();
        }
    }
}
