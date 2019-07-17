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
        Query query = new Query();
        Priority priority = new Priority();
        Status status = new Status();
        public int userId { get; set; } = 0;
        public int permissionId { get; set; } = 0;
        int selectedId;
        int selectedReqId;
        int currentAssignedSACode;
        int stat;
        string currentUser;

        public FrmSaUser(int activeUserId)
        {
            InitializeComponent();
            userId = activeUserId;
            permissionId = query.GetPermissionByUserId(userId);
            RefreshRequestsData();
        }

        private void RefreshRequestsData()
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var getRequestsQuery = (from a in dc.GetTicketTransactionList()
                                   select a).ToList();
            var getUserListQuery = from a in dc.GetTable<User>()
                                   select a;
            var getSAMembers = (from a in dc.GetSAMembers()
                                select a.LastName).ToList();
            DgvGetRequests.DataSource = getRequestsQuery; 
            DgvUserList.DataSource = getUserListQuery;
            CboAssignedSA.DataSource = getSAMembers;
        }

        private void FrmSaUser_Load(object sender, EventArgs e)
        {
            RefreshRequestsData();
            if (LblGetID.Text == "0")
            {
                BtnCancel.Visible = false;
                BtnUpdate.Visible = false;
                BtnAssignedSA.Visible = false;
            }

        }

        private void LblLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLogin Log = new FrmLogin();
            Log.Show();
        }

      

        private void DgvGetRequests_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in DgvGetRequests.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                var x = row.Cells["Id"].Value.ToString();
                selectedReqId = Convert.ToInt32(x);
                LblSelectedReqID.Text = x;
            }
        }

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

        private void DgvGetRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            BtnCancel.Visible = true;
            BtnUpdate.Visible = true;
            BtnAssignedSA.Visible = true;
            if (DgvGetRequests.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {               
                DgvGetRequests.CurrentRow.Selected = true;
                var id = DgvGetRequests.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                var ticketid = DgvGetRequests.Rows[e.RowIndex].Cells["TicketID"].FormattedValue.ToString();
                var first = DgvGetRequests.Rows[e.RowIndex].Cells["FirstName"].FormattedValue.ToString();
                var last = DgvGetRequests.Rows[e.RowIndex].Cells["LastName"].FormattedValue.ToString();
                var issue = DgvGetRequests.Rows[e.RowIndex].Cells["IssueType"].FormattedValue.ToString();
                var prioritylvl = DgvGetRequests.Rows[e.RowIndex].Cells["PriorityLevel"].FormattedValue.ToString();
                var department = DgvGetRequests.Rows[e.RowIndex].Cells["Department"].FormattedValue.ToString();
                var note = DgvGetRequests.Rows[e.RowIndex].Cells["Note"].FormattedValue.ToString();
                var assignedsa = DgvGetRequests.Rows[e.RowIndex].Cells["AssignedSAID"].FormattedValue.ToString();
                var actiondone = DgvGetRequests.Rows[e.RowIndex].Cells["ActionDone"].FormattedValue.ToString();
                var statuscode = DgvGetRequests.Rows[e.RowIndex].Cells["StatusCode"].FormattedValue.ToString();
                selectedReqId = Convert.ToInt32(id);
                LblSelectedReqID.Text = id;
                LblGetDept.Text = department;
                LblGetID.Text = id;
                LblGetTicketID.Text = ticketid;
                LblGetFirstName.Text = first;
                LblGetLastName.Text = last;
                TxtGetNote.Text = note;
                TxtGetIssue.Text = issue;
                stat = Convert.ToInt32(statuscode);
                currentAssignedSACode = Convert.ToInt32(statuscode);
                LblGetStatus.Text = status.GetStatusValueByID(currentAssignedSACode);
                TxtAction.Text = actiondone;
                string xPL = priority.GetReversePriorityValue(prioritylvl);
                CboPriorityLevel.SelectedItem = xPL;
                CboAssignedSA.SelectedItem = GetSALastNameByID(Convert.ToInt32(assignedsa));
                if (stat <= 1)
                {
                    BtnAssignedSA.Visible = true;
                    CboAssignedSA.Visible = false;
                }
                else
                {
                    BtnAssignedSA.Visible = false;
                    CboAssignedSA.Visible = true;
                }
            }
        }

        private string GetSALastNameByID(int id)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            if (id > 0)
            {
                var getSAMembers = (from a in dc.GetSAMembers()
                                    where a.Id == id
                                     select a.LastName).FirstOrDefault();
                return getSAMembers.ToString();
            }
            else
            {
                return "Admin";
            }
        }

        private int GetSAIdByLastName(string LastName)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var getSAID = (from a in dc.GetSAMembers()
                                where a.LastName == LastName
                                select a.Id).FirstOrDefault();
            return getSAID;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int ticketid = Convert.ToInt32(LblGetTicketID.Text);
            int prioritynumber = priority.GetPriorityValue(CboPriorityLevel.SelectedItem.ToString());
            int id = Convert.ToInt32(LblGetID.Text);
            int saidcode = GetSAIdByLastName(CboAssignedSA.SelectedItem.ToString());
            currentUser = query.GetNameByUserID(userId);
            query.UpdateTicketTransactionList(ticketid, TxtGetIssue.Text, prioritynumber, TxtGetNote.Text, id, stat, TxtAction.Text, saidcode, currentUser);
            RefreshRequestsData();
        }

        private void BtnAssignedSA_Click(object sender, EventArgs e)
        {
            stat = 2;
            CboAssignedSA.Visible = true;
            BtnAssignedSA.Visible = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt32(LblGetID.Text);
           
            string cancelQuestion = "Are you sure you want to cancel this ticket transaction #" + LblGetID.Text + " ?";
            string title = "Hi" + currentUser + " !";
            switch (MessageBox.Show(cancelQuestion, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    MessageBox.Show("Successfully Cancelled.");
                    query.CancelTicket(selectedId);
                    break;
                case DialogResult.No:
                    MessageBox.Show("You pressed No.");
                    break;
                default:
                    break;
            }
            RefreshRequestsData();                     
        }


    }
}
