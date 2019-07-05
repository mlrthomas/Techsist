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
    
        public Query() {}
        
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

        public void InsertTicketInformation(int id, string issue, int priority, string note)
        {
            TechsistDataClassesDataContext dc = new TechsistDataClassesDataContext(con);
            dc.InsertTicket(id, issue, priority, note);
            dc.SubmitChanges();
        }

    }
}
