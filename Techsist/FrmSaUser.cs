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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maria\source\repos\Techsist\Techsist\TechsistDatabase.mdf;Integrated Security=True");
        public FrmSaUser()
        {
            InitializeComponent();
        }

        private void RefreshRequestsData()
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.GetTicketTransactionList();

            var getRequestsQuery = from a in dc.GetTicketTransactionList()
                                   select a;
            DgvGetRequests.DataSource = getRequestsQuery;
        }

        private void FrmSaUser_Load(object sender, EventArgs e)
        {
            RefreshRequestsData();
        }

        private void LblLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLogin Log = new FrmLogin();
            Log.Show();
        }

        int selectedId;

        private void DgvUserList_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in DgvUserList.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                var x = row.Cells["Id"].Value.ToString();
                selectedId = Convert.ToInt32(x);
                LblSelectedID.Text = x;
            }
        }

      
    }
}
