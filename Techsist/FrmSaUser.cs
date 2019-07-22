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
        int currentAssignedSACode;
        int stat;
        string currentUser;
        int selectedIssueId;
      

        public FrmSaUser(int activeUserId)
        {
            InitializeComponent();
            userId = activeUserId;
            permissionId = query.GetPermissionByUserId(userId);
            RefreshRequestsData();
            if(permissionId != 2)
            {
                GboSAWorkSummary.Visible = false;
                GBoUList.Visible = false;
                BtnForReview.Visible = false;
                BtnUnassigned.Visible = false;
                LblUnassignedCount.Visible = false;
                LblForReview.Visible = false;
                GrpReqForm.Visible = false;
                GboSAMyTasks.Visible = true;
            }
          
        }

        private void RefreshRequestsData()
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var getRequestsQuery = (from a in dc.GetTicketTransactionList()
                                   select a).ToList();
            var getUserListQuery = from a in dc.GetTable<User>()
                                   select a;
            var getSAMembers = (from a in dc.GetSAMembers()
                                select a.Name).ToList();
            var getUnassignedDataQuery = (from a in dc.GetUnassignTicket()
                                          select a).ToList();
            var getSAMembersList = (from a in dc.GetSAMembers()
                                select a).ToList();
            var getSAPendingTasks = (from a in dc.GetSATasksBySaId(userId,2)
                                     select a).ToList();
            var getSAOnGoingTasks = (from a in dc.GetSATasksBySaId(userId, 3)
                                     select a).ToList();

            DgvGetRequests.DataSource = getRequestsQuery; 
            DgvUserList.DataSource = getUserListQuery;
            CboAssignedSA.DataSource = getSAMembers;
            CboUAssignedSA.DataSource = getSAMembers;
            LblUnassignedCount.Text = (query.GetCountUnassigned()).ToString();
            LblForReview.Text = (query.GetCountDone()).ToString();
            DgvUnassignedReview.DataSource = getUnassignedDataQuery;
            DgvSAMembers.DataSource = getSAMembersList;
            DgvSAPendingTasks.DataSource = getSAPendingTasks;
            DgvSAOnGoingTasks.DataSource = getSAOnGoingTasks;
            GboOngoingTasks.Text = "On-going Tasks: " + (query.GetCountDoneById(userId)).ToString();
            GboPendingTasks.Text = "Pending Tasks: " + (query.GetCountInprocessById(userId)).ToString();
        }

        private void FrmSaUser_Load(object sender, EventArgs e)
        {
            RefreshRequestsData();
            if (LblGetID.Text == "0")
            {
                GrpReqForm.Visible = false;
            } 
        }

        private void LblLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLogin Log = new FrmLogin();
            Log.Show();
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
            if(permissionId != 2)
            {
                GrpReqForm.Visible = false;
            }
            else { 
            GrpReqForm.Visible = true;
            }
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
                selectedId = Convert.ToInt32(id);
                LblSelectedID.Text = id;
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
                                     select a.Name).FirstOrDefault();
                return getSAMembers.ToString();
            }
            else
            {
                return "Admin";
            }
        }

        private int GetSAIdByName(string Name)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var getSAID = (from a in dc.GetSAMembers()
                                where a.Name == Name
                                select a.Id).FirstOrDefault();
            return getSAID;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int ticketid = Convert.ToInt32(LblGetTicketID.Text);
            int prioritynumber = priority.GetPriorityValue(CboPriorityLevel.SelectedItem.ToString());
            int id = Convert.ToInt32(LblGetID.Text);
            int saidcode = GetSAIdByName(CboAssignedSA.SelectedItem.ToString());
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

        private void BtnUnassigned_Click(object sender, EventArgs e)
        {
            RefreshRequestsData();
            BtnUSubmit.Visible = false;
            LblUAssignedSA.Visible = true;
            BtnUAssignedSA.Visible = true;
            LblUActionDone.Visible = false;
            TxtUActionDone.Visible = false;
            GBoUList.Text = "Unassigned Lists";
        }

        private void BtnUAssignedSA_Click(object sender, EventArgs e)
        {
            BtnUAssignedSA.Visible = false;
            CboUAssignedSA.Visible = true;
            BtnUSubmit.Visible = true;
        }

        private void DgvUnassignedReview_SelectionChanged(object sender, EventArgs e)
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
                LblUGetId.Text = x;
            }
        }

        private void DgvUnassignedReview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1) return;
            if (DgvGetRequests.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DgvUnassignedReview.CurrentRow.Selected = true;
                var id = DgvUnassignedReview.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                var prioritylvl = DgvUnassignedReview.Rows[e.RowIndex].Cells["PriorityLevel"].FormattedValue.ToString();
                var issue = DgvUnassignedReview.Rows[e.RowIndex].Cells["IssueType"].FormattedValue.ToString();
                string xPL = priority.GetReversePriorityValue(prioritylvl);
                LblUGetId.Text = id;
                LblUGetIssue.Text = issue;
                LblUGetPriority.Text = xPL;
                BtnUAssignedSA.Visible = true;
                BtnUSubmit.Visible = false;
                CboUAssignedSA.Visible = false;
            }
        }



        private void BtnUSubmit_Click(object sender, EventArgs e)
        {
            CboUAssignedSA.Visible = false;
            BtnUSubmit.Visible = false;
            BtnUAssignedSA.Visible = true;
            BtnUSubmit.Visible = false;
            selectedId = Convert.ToInt32(LblUGetId.Text);
            int said = GetSAIdByName(CboAssignedSA.SelectedItem.ToString());
            query.AssignedSAById(selectedId, said);
            RefreshRequestsData();
        }

        private void BtnForReview_Click(object sender, EventArgs e)
        {
            LblUGetId.Text = "0";
            LblUGetIssue.Text = "0";
            LblUGetPriority.Text = "0";
            GBoUList.Text = "For Review";
            LblUActionDone.Visible = true;
            TxtUActionDone.Visible = true;
            LblUAssignedSA.Visible = false;
            CboUAssignedSA.Visible = false;
            BtnUAssignedSA.Visible = false;
            DgvUnassignedReview.DataSource = query.GetCountDone();
        }

        private void BtnUApprove_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt32(LblUGetId.Text);
            query.ApprovedTicket(selectedId);
        }

        private void DgvSAMembers_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in  DgvSAMembers.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                var name = row.Cells["Name"].Value.ToString();
                var Id = row.Cells["Id"].Value.ToString();
                int sId = Convert.ToInt32(Id);
                LblGetSAName.Text = name;
                LblGetSAAssignedWork.Text = (query.GetCountAssignedById(sId)).ToString();
                LblGetSAInprocess.Text = (query.GetCountInprocessById(sId)).ToString();
                LblGetApproval.Text = (query.GetCountDoneById(sId)).ToString();
                if (LblGetSAAssignedWork.Text == "0" && LblGetSAInprocess.Text == "0")
                {
                    LblBusy.Text = "NOT BUSY";
                    LblBusy.ForeColor = Color.FromArgb(0, 255, 0);
                }
                else
                {
                    LblBusy.Text = "BUSY";
                    LblBusy.ForeColor = Color.FromArgb(255, 0, 0);
                }
            }
        }

        private void DgvSAPendingTasks_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in DgvSAPendingTasks.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                var xId = row.Cells["Id"].Value.ToString();
                var xIssue = row.Cells["IssueType"].Value.ToString();
                selectedIssueId = Convert.ToInt32(xId);
                LblGetIssue.Text = xIssue;
            }
        }

        private void BtnStartTasks_Click(object sender, EventArgs e)
        {
            query.StartTask(selectedIssueId);
            RefreshRequestsData();
        }

        private void BtnDoneTask_Click(object sender, EventArgs e)
        {
            query.FinishTask(selectedIssueId, (TxtFActionDone.Text).ToString());
            RefreshRequestsData();
        }
    }
}
