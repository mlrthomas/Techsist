using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techsist
{
    public class Priority
    {
        public Priority() { }

        public int GetPriorityValue(string priorityText)
        {
            if (priorityText == "High")
            {
                return 3;
            }
            else if (priorityText == "Medium")
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        public string GetReversePriorityValue(string pValue)
        {
            if (pValue == "3")
            {
                return "High";
            }
            else if (pValue == "2")
            {
                return "Medium";
            }
            else
            {
                return "Low";
            }
        }
    }
}
