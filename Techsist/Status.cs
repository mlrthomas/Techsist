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
                return "in-process";
            }
            else if (id == 2)
            {
                return "assigned";
            }
            else
            {
                return "unassigned";
            }
        }

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
            else if (status == "done")
            {
                return 4;
            }
            else if (status == "in-process")
            {
                return 3;
            }
            else if (status == "assigned")
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
