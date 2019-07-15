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

        public Query() { }

        public string GetDepartment(string userEmailInput)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var queryDepartment =
                (from a in dc.GetTable<User>()
                 where a.Email == userEmailInput
                 select a.Department).FirstOrDefault();
            return queryDepartment;
        }

        public string GetPassword(string userEmailInput)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var queryPassword =
                (from a in dc.GetTable<User>()
                 where a.Email == userEmailInput
                 select a.Password).FirstOrDefault();
            return queryPassword;
        }

        public int GetUserId(string userEmailInput)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var queryUserId =
                (from a in dc.GetTable<User>()
                 where a.Email == userEmailInput
                 select a.Id).FirstOrDefault();
            return queryUserId;
        }

        public int GetPermissionByUserId(int userIdInput)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var queryPermission =
                (from a in dc.GetTable<User>()
                 where a.Id == userIdInput
                 select a.Permission).FirstOrDefault();
            return queryPermission;
        }

        public string GetNameByUserID(int id)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var queryUserName =
                (from a in dc.GetTable<User>()
                 where a.Id == id
                 select a.FirstName + " " + a.LastName).FirstOrDefault();
            return queryUserName;
        }

        public int GetTicketId(int userid, string issue)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            var queryTicketID =
                (from a in dc.GetTable<Ticket>()
                 where a.UserID == userid && a.IssueType == issue
                 select a.Id).FirstOrDefault();
            return queryTicketID;
        }

        public void InsertTicketInformation(int id, string issue, int priority, string note)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.InsertTicket(id, issue, priority, note);
            dc.SubmitChanges();
        }

        public void InsertTicketTransaction(int id, int status, string actiondone, int SaId, string modBy)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.InsertTicketTransaction(id, status, actiondone, SaId, modBy);
            dc.SubmitChanges();
        }

        public void UpdateTicket(int ticketid, string issue, int priority, string note)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.UpdateTicketInformation(ticketid, issue, priority, note);
            dc.SubmitChanges();
        }

        public void DeleteTicket(int ticketid)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.DeleteTicket(ticketid);
            dc.SubmitChanges();
        }

        public void GetTicketTransactionList()
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.GetTicketTransactionList();
            dc.SubmitChanges();
        }

        public void GetSAMembers()
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.GetSAMembers();
        }
    }
}

