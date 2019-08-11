using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techsist
{
    public class Status
    {
        public Status() { }

        //Gets status value by status code ID
        public string GetStatusValueByID(int id)
        {
            if (id == 6)
            {
                return "Cancelled";
            }
            else if (id == 5)
            {
                return "Completed";
            }
            else if (id == 4)
            {
                return "Done";
            }
            else if (id == 3)
            {
                return "In-process";
            }
            else if (id == 2)
            {
                return "Assigned";
            }
            else
            {
                return "Unassign";
            }
        }

        //Get Status id by status value
        public int GetStatusCodeByString(string status)
        {
            if (status == "Cancelled")
            {
                return 6;
            }
            else if (status == "Completed")
            {
                return 5;
            }
            else if (status == "Done")
            {
                return 4;
            }
            else if (status == "In-process")
            {
                return 3;
            }
            else if (status == "Assigned")
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

    }
}
