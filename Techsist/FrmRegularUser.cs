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
        Query query = new Query();
        Priority priority = new Priority();
       
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
            
            query.InsertTicketInformation(userId, TxtIssue.Text, priority.GetPriorityValue(CboPriorityLevel.Text), TxtNote.Text);
            query.InsertTicketTransaction(query.GetTicketId(userId, TxtIssue.Text), 0, "", 0, query.GetNameByUserID(userId));
            MessageBox.Show("Successfully Submitted");
        }

     

        private void RefreshData()
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var requestslinqsprocquery = (from a in dc.GetViewRequests(userId)
                                          select a).ToList();

            DgvViewRequests.DataSource = requestslinqsprocquery;
        }

     

        private void FrmRegularUser_Load(object sender, EventArgs e)
        {
            RefreshData();
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
                var xId = row.Cells["Id"].Value.ToString();
                var xIssueType = row.Cells["IssueType"].Value.ToString();
                var xPriorityLevel = (row.Cells["PriorityLevel"]).Value.ToString();
                string xPL = priority.GetReversePriorityValue(xPriorityLevel);
                var xNote = row.Cells["Note"].Value.ToString();
                LblSelectedId.Text = xId;
                TxtEditIssue.Text = xIssueType;
                TxtEditNote.Text = xNote;
                CboEditPriorityLevel.SelectedItem = xPL;
                BtnEdit.Visible = true;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DgvViewRequests.Visible = false;
            LblEditIssue.Visible = true;
            LblEditPriorityLevel.Visible = true;
            LblEditNote.Visible = true;
            TxtEditIssue.Visible = true;
            TxtEditNote.Visible = true;
            CboEditPriorityLevel.Visible = true;
            BtnCancel.Visible = true;
            BtnEdit.Visible = false;
            BtnUpdate.Visible = true;
            BtnDelete.Visible = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DgvViewRequests.Visible = true;
            LblEditIssue.Visible = false;
            LblEditPriorityLevel.Visible = false;
            LblEditNote.Visible = false;
            TxtEditIssue.Visible = false;
            TxtEditNote.Visible = false;
            CboEditPriorityLevel.Visible = false;
            BtnCancel.Visible = false;
            BtnUpdate.Visible = false;
            BtnEdit.Visible = true;
            BtnDelete.Visible = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DgvViewRequests.Visible = true;
            LblEditIssue.Visible = false;
            LblEditPriorityLevel.Visible = false;
            LblEditNote.Visible = false;
            TxtEditIssue.Visible = false;
            TxtEditNote.Visible = false;
            CboEditPriorityLevel.Visible = false;
            BtnUpdate.Visible = false;
            BtnCancel.Visible = false;
            BtnDelete.Visible = true;
            BtnEdit.Visible = true;
            int ticketid = Convert.ToInt32(LblSelectedId.Text);
            int prioritylvl = priority.GetPriorityValue((CboEditPriorityLevel.SelectedItem).ToString());
            query.UpdateTicket(ticketid, TxtEditIssue.Text, prioritylvl, TxtEditNote.Text);
            RefreshData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int ticketid = Convert.ToInt32(LblSelectedId.Text);
            query.DeleteTicket(ticketid);
            RefreshData();
        }
    }
}
