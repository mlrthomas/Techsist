using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Techsist
{
    public partial class FrmRegularUser : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maria\source\repos\Techsist\Techsist\TechsistDatabase.mdf;Integrated Security=True");

        public int userId { get; set; } = 0;

        public FrmRegularUser(int activeUserId)
        {
            InitializeComponent();
            userId = activeUserId;
        }


        private void LblLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLogin Log = new FrmLogin();
            Log.Show();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Query query = new Query();
            query.InsertTicketInformation(userId, TxtIssue.Text, GetPriorityValue(CboPriorityLevel.Text), TxtNote.Text);
            MessageBox.Show("Successfully Submitted");
        }

        private int GetPriorityValue(string priorityText)
        {
            if (priorityText == "High")
            {
                return 3;
            }else if (priorityText == "Medium")
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        private void FrmRegularUser_Load(object sender, EventArgs e)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.GetViewRequests(userId);

            var getRequestsQuery = from a in dc.GetTable<Ticket>()
                              select a;
            DgvViewRequests.DataSource = getRequestsQuery;
        }

      

        private void DgvViewRequests_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in DgvViewRequests.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                var x = row.Cells["IssueType"].Value.ToString();
                LblSelectedIssue.Text = x;
            }
        }
    }
}
