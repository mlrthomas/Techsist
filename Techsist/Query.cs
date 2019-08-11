using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techsist
{
    public class Query
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maria\source\repos\Techsist\Techsist\TechsistDatabase.mdf;Integrated Security=True");
        public Query() {
            
        }

        //Gets the department by email
        public string GetDepartment(string userEmailInput)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var queryDepartment =
                (from a in dc.GetTable<User>()
                 where a.Email == userEmailInput
                 select a.Department).FirstOrDefault();
            return queryDepartment;
        }

        //Gets Password by email
        public string GetPassword(string userEmailInput)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var queryPassword =
                (from a in dc.GetTable<User>()
                 where a.Email == userEmailInput
                 select a.Password).FirstOrDefault();
            return queryPassword;
        }

        //Gets UserId by email
        public int GetUserId(string userEmailInput)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var queryUserId =
                (from a in dc.GetTable<User>()
                 where a.Email == userEmailInput
                 select a.Id).FirstOrDefault();
            return queryUserId;
        }

        //GetsPermissionByUserId
        public int GetPermissionByUserId(int userIdInput)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var queryPermission =
                (from a in dc.GetTable<User>()
                 where a.Id == userIdInput
                 select a.Permission).FirstOrDefault();
            return queryPermission;
        }

        //Gets the name by user id as an argument
        public string GetNameByUserID(int id)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var queryUserName =
                (from a in dc.GetTable<User>()
                 where a.Id == id
                 select a.FirstName + " " + a.LastName).FirstOrDefault();
            return queryUserName;
        }

        //Gets the ticket id by userid and issue
        public int GetTicketId(int userid, string issue)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var queryTicketID =
                (from a in dc.GetTable<Ticket>()
                 where a.UserID == userid && a.IssueType == issue
                 select a.Id).FirstOrDefault();
            return queryTicketID;
        }

        //Insert TicketInformation
        public void InsertTicketInformation(int id, string issue, int priority, string note)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.InsertTicket(id, issue, priority, note);
            dc.SubmitChanges();
        }

        //Insert TicketInformation
        public void InsertTicketTransaction(int id, int status, string actiondone, int SaId, string modBy)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.InsertTicketTransaction(id, status, actiondone, SaId, modBy);
            dc.SubmitChanges();
        }

        //Update Ticket information
        public void UpdateTicket(int ticketid, string issue, int priority, string note)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.UpdateTicketInformation(ticketid, issue, priority, note);
            dc.SubmitChanges();
        }

        //Delete Ticket Information
        public void DeleteTicket(int ticketid)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.DeleteTicket(ticketid);
            dc.SubmitChanges();
        }

        //Get TicketTransactionList
        public void GetTicketTransactionList()
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.GetTicketTransactionList();
            dc.SubmitChanges();
        }

        //Get SA Members
        public void GetSAMembers()
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.GetSAMembers();
        }

        //Updates the TicketTransaction list
        public void UpdateTicketTransactionList(int ticketid, string issue, int priority, string note, int id, int status, string action, int said, string modby)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.UpdateTicketInformation(ticketid, issue, priority, note);
            dc.UpdateTicketTransaction(id, status, action, said, modby);
            dc.SubmitChanges();
        }

        //Cancel or deletes the ticket
        public void CancelTicket(int id)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.CancelTicket(id);
            dc.SubmitChanges();
        }

        //Counts the number of Unassign tickets
        public int GetCountUnassigned()
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            int UnassignedCount = (from a in dc.GetTable<TicketTransaction>()
                                        where a.StatusCode <= 1
                                        select a).Count();
            return UnassignedCount;
        }

        //Counts the number of assign tickets
        public int GetCountAssignedById(int id)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            int UnassignedCount = (from a in dc.GetTable<TicketTransaction>()
                                   where a.StatusCode <= 2 && a.AssignedSAID == id
                                   select a).Count();
            return UnassignedCount;
        }

        //Counts the tickets with the status "Done"
        public int GetCountDone()
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            int UnassignedCount = (from a in dc.GetTable<TicketTransaction>()
                                   where a.StatusCode == 4
                                   select a).Count();
            return UnassignedCount;
        }

        //Counts the Done status by userId
        public int GetCountDoneById(int id)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            int UnassignedCount = (from a in dc.GetTable<TicketTransaction>()
                                   where a.StatusCode == 4 && a.AssignedSAID == id
                                   select a).Count();
            return UnassignedCount;
        }

        //Counts the total Inprocess tickets
        public int GetCountInprocess()
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            int InprocessCount = (from a in dc.GetTable<TicketTransaction>()
                                   where a.StatusCode == 3
                                   select a).Count();
            return InprocessCount;
        }

        //Counts the inprocess ticket by id 
        public int GetCountInprocessById(int id)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            int InprocessCount = (from a in dc.GetTable<TicketTransaction>()
                                  where a.StatusCode == 3 && a.AssignedSAID == id
                                  select a).Count();
            return InprocessCount;
        }

        //Assign sa by using ticket id and SA id as an arguments
        public void AssignedSAById(int iId, int iAssignedSAID)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.AssignedSA(iId, iAssignedSAID);
            dc.SubmitChanges();
        }

        //Approved the ticket and change the status code
        public void ApprovedTicket(int id)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            TicketTransaction tickTrans = dc.TicketTransactions.Single(TicketTransaction => TicketTransaction.TicketID == id);
            tickTrans.StatusCode = 5;
            dc.SubmitChanges();
        }

        //Start the task function and change the status code to 3
        public void StartTask(int id)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            TicketTransaction tickTrans = dc.TicketTransactions.Single(TicketTransaction => TicketTransaction.TicketID == id);
            tickTrans.StatusCode = 3;
            dc.SubmitChanges();
        }

        //Finish task function and change the status code to 4
        public void FinishTask(int id, string action)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            TicketTransaction tickTrans = dc.TicketTransactions.Single(TicketTransaction => TicketTransaction.TicketID == id);
            tickTrans.StatusCode = 4;
            tickTrans.ActionDone = action;
            dc.SubmitChanges();
        }

    }
}


