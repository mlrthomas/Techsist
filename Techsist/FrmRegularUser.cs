using System;
using System.Collections.Generic;
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
    }
}
