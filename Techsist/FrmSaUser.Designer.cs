namespace Techsist
{
    partial class FrmSaUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblLogout = new System.Windows.Forms.Label();
            this.LblWelcomeSA = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.TbcSaUser = new System.Windows.Forms.TabControl();
            this.TbpRequests = new System.Windows.Forms.TabPage();
            this.DgvGetRequests = new System.Windows.Forms.DataGridView();
            this.TbpSATasks = new System.Windows.Forms.TabPage();
            this.TbpSummary = new System.Windows.Forms.TabPage();
            this.TbpUserLists = new System.Windows.Forms.TabPage();
            this.LblSelectedID = new System.Windows.Forms.Label();
            this.DgvUserList = new System.Windows.Forms.DataGridView();
            this.LblSelectedReqID = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            this.LblTicketID = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.LblIssue = new System.Windows.Forms.Label();
            this.LblPriority = new System.Windows.Forms.Label();
            this.LblAssignedSA = new System.Windows.Forms.Label();
            this.LblNote = new System.Windows.Forms.Label();
            this.LblGetID = new System.Windows.Forms.Label();
            this.LblGetTicketID = new System.Windows.Forms.Label();
            this.TxtGetIssue = new System.Windows.Forms.TextBox();
            this.CboPriorityLevel = new System.Windows.Forms.ComboBox();
            this.LblGetDept = new System.Windows.Forms.Label();
            this.TxtGetNote = new System.Windows.Forms.TextBox();
            this.CboAssignedSA = new System.Windows.Forms.ComboBox();
            this.LblGetFirstName = new System.Windows.Forms.Label();
            this.LblGetLastName = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblGetStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.TbcSaUser.SuspendLayout();
            this.TbpRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGetRequests)).BeginInit();
            this.TbpUserLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLogout
            // 
            this.LblLogout.AutoSize = true;
            this.LblLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblLogout.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Underline);
            this.LblLogout.ForeColor = System.Drawing.Color.White;
            this.LblLogout.Location = new System.Drawing.Point(663, 49);
            this.LblLogout.Name = "LblLogout";
            this.LblLogout.Size = new System.Drawing.Size(73, 24);
            this.LblLogout.TabIndex = 7;
            this.LblLogout.Text = "Logout";
            this.LblLogout.Click += new System.EventHandler(this.LblLogout_Click);
            // 
            // LblWelcomeSA
            // 
            this.LblWelcomeSA.AutoSize = true;
            this.LblWelcomeSA.BackColor = System.Drawing.Color.Transparent;
            this.LblWelcomeSA.Font = new System.Drawing.Font("Berlin Sans FB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcomeSA.ForeColor = System.Drawing.Color.White;
            this.LblWelcomeSA.Location = new System.Drawing.Point(238, 33);
            this.LblWelcomeSA.Name = "LblWelcomeSA";
            this.LblWelcomeSA.Size = new System.Drawing.Size(313, 58);
            this.LblWelcomeSA.TabIndex = 6;
            this.LblWelcomeSA.Text = "Welcome SA!";
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.Image = global::Techsist.Properties.Resources.Logo;
            this.PicLogo.Location = new System.Drawing.Point(74, 22);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(76, 71);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 5;
            this.PicLogo.TabStop = false;
            // 
            // TbcSaUser
            // 
            this.TbcSaUser.Controls.Add(this.TbpRequests);
            this.TbcSaUser.Controls.Add(this.TbpSATasks);
            this.TbcSaUser.Controls.Add(this.TbpSummary);
            this.TbcSaUser.Controls.Add(this.TbpUserLists);
            this.TbcSaUser.Font = new System.Drawing.Font("Arial", 9.25F);
            this.TbcSaUser.Location = new System.Drawing.Point(12, 115);
            this.TbcSaUser.Name = "TbcSaUser";
            this.TbcSaUser.SelectedIndex = 0;
            this.TbcSaUser.Size = new System.Drawing.Size(778, 573);
            this.TbcSaUser.TabIndex = 8;
            // 
            // TbpRequests
            // 
            this.TbpRequests.BackColor = System.Drawing.Color.Teal;
            this.TbpRequests.Controls.Add(this.LblGetStatus);
            this.TbpRequests.Controls.Add(this.LblStatus);
            this.TbpRequests.Controls.Add(this.LblGetLastName);
            this.TbpRequests.Controls.Add(this.LblGetFirstName);
            this.TbpRequests.Controls.Add(this.CboAssignedSA);
            this.TbpRequests.Controls.Add(this.TxtGetNote);
            this.TbpRequests.Controls.Add(this.LblGetDept);
            this.TbpRequests.Controls.Add(this.CboPriorityLevel);
            this.TbpRequests.Controls.Add(this.TxtGetIssue);
            this.TbpRequests.Controls.Add(this.LblGetTicketID);
            this.TbpRequests.Controls.Add(this.LblGetID);
            this.TbpRequests.Controls.Add(this.LblAssignedSA);
            this.TbpRequests.Controls.Add(this.LblNote);
            this.TbpRequests.Controls.Add(this.LblPriority);
            this.TbpRequests.Controls.Add(this.LblIssue);
            this.TbpRequests.Controls.Add(this.LblDepartment);
            this.TbpRequests.Controls.Add(this.LblLastName);
            this.TbpRequests.Controls.Add(this.LblFirstName);
            this.TbpRequests.Controls.Add(this.LblTicketID);
            this.TbpRequests.Controls.Add(this.LblId);
            this.TbpRequests.Controls.Add(this.BtnDelete);
            this.TbpRequests.Controls.Add(this.BtnUpdate);
            this.TbpRequests.Controls.Add(this.LblSelectedReqID);
            this.TbpRequests.Controls.Add(this.DgvGetRequests);
            this.TbpRequests.Location = new System.Drawing.Point(4, 24);
            this.TbpRequests.Name = "TbpRequests";
            this.TbpRequests.Padding = new System.Windows.Forms.Padding(3);
            this.TbpRequests.Size = new System.Drawing.Size(770, 545);
            this.TbpRequests.TabIndex = 0;
            this.TbpRequests.Text = "Requests";
            // 
            // DgvGetRequests
            // 
            this.DgvGetRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGetRequests.Location = new System.Drawing.Point(17, 22);
            this.DgvGetRequests.Name = "DgvGetRequests";
            this.DgvGetRequests.Size = new System.Drawing.Size(747, 217);
            this.DgvGetRequests.TabIndex = 0;
            this.DgvGetRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGetRequests_CellClick);
            // 
            // TbpSATasks
            // 
            this.TbpSATasks.BackColor = System.Drawing.Color.Teal;
            this.TbpSATasks.Location = new System.Drawing.Point(4, 24);
            this.TbpSATasks.Name = "TbpSATasks";
            this.TbpSATasks.Padding = new System.Windows.Forms.Padding(3);
            this.TbpSATasks.Size = new System.Drawing.Size(726, 284);
            this.TbpSATasks.TabIndex = 1;
            this.TbpSATasks.Text = "SA Tasks";
            // 
            // TbpSummary
            // 
            this.TbpSummary.BackColor = System.Drawing.Color.Teal;
            this.TbpSummary.Location = new System.Drawing.Point(4, 24);
            this.TbpSummary.Name = "TbpSummary";
            this.TbpSummary.Size = new System.Drawing.Size(726, 284);
            this.TbpSummary.TabIndex = 2;
            this.TbpSummary.Text = "Summary";
            // 
            // TbpUserLists
            // 
            this.TbpUserLists.Controls.Add(this.LblSelectedID);
            this.TbpUserLists.Controls.Add(this.DgvUserList);
            this.TbpUserLists.Location = new System.Drawing.Point(4, 24);
            this.TbpUserLists.Name = "TbpUserLists";
            this.TbpUserLists.Size = new System.Drawing.Size(726, 284);
            this.TbpUserLists.TabIndex = 3;
            this.TbpUserLists.Text = "UserLists";
            this.TbpUserLists.UseVisualStyleBackColor = true;
            this.TbpUserLists.Click += new System.EventHandler(this.FrmSaUser_Load);
            // 
            // LblSelectedID
            // 
            this.LblSelectedID.AutoSize = true;
            this.LblSelectedID.Location = new System.Drawing.Point(34, 195);
            this.LblSelectedID.Name = "LblSelectedID";
            this.LblSelectedID.Size = new System.Drawing.Size(71, 16);
            this.LblSelectedID.TabIndex = 1;
            this.LblSelectedID.Text = "SelectedID";
            // 
            // DgvUserList
            // 
            this.DgvUserList.AllowUserToOrderColumns = true;
            this.DgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUserList.Location = new System.Drawing.Point(33, 20);
            this.DgvUserList.Name = "DgvUserList";
            this.DgvUserList.Size = new System.Drawing.Size(590, 154);
            this.DgvUserList.TabIndex = 0;
            this.DgvUserList.SelectionChanged += new System.EventHandler(this.DgvUserList_SelectionChanged);
            // 
            // LblSelectedReqID
            // 
            this.LblSelectedReqID.AutoSize = true;
            this.LblSelectedReqID.Location = new System.Drawing.Point(14, 255);
            this.LblSelectedReqID.Name = "LblSelectedReqID";
            this.LblSelectedReqID.Size = new System.Drawing.Size(94, 16);
            this.LblSelectedReqID.TabIndex = 1;
            this.LblSelectedReqID.Text = "SelectedReqID";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(546, 487);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(80, 26);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(348, 487);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(80, 26);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Location = new System.Drawing.Point(38, 302);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(21, 15);
            this.LblId.TabIndex = 4;
            this.LblId.Text = "ID:";
            // 
            // LblTicketID
            // 
            this.LblTicketID.AutoSize = true;
            this.LblTicketID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTicketID.Location = new System.Drawing.Point(38, 328);
            this.LblTicketID.Name = "LblTicketID";
            this.LblTicketID.Size = new System.Drawing.Size(64, 15);
            this.LblTicketID.TabIndex = 5;
            this.LblTicketID.Text = "TICKET ID:";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstName.Location = new System.Drawing.Point(38, 356);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(78, 15);
            this.LblFirstName.TabIndex = 6;
            this.LblFirstName.Text = "FIRST NAME:";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastName.Location = new System.Drawing.Point(38, 385);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(76, 15);
            this.LblLastName.TabIndex = 7;
            this.LblLastName.Text = "LAST NAME:";
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepartment.Location = new System.Drawing.Point(355, 303);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(90, 15);
            this.LblDepartment.TabIndex = 8;
            this.LblDepartment.Text = "DEPARTMENT :";
            // 
            // LblIssue
            // 
            this.LblIssue.AutoSize = true;
            this.LblIssue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIssue.Location = new System.Drawing.Point(38, 412);
            this.LblIssue.Name = "LblIssue";
            this.LblIssue.Size = new System.Drawing.Size(44, 15);
            this.LblIssue.TabIndex = 9;
            this.LblIssue.Text = "ISSUE:";
            // 
            // LblPriority
            // 
            this.LblPriority.AutoSize = true;
            this.LblPriority.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPriority.Location = new System.Drawing.Point(38, 437);
            this.LblPriority.Name = "LblPriority";
            this.LblPriority.Size = new System.Drawing.Size(102, 15);
            this.LblPriority.TabIndex = 10;
            this.LblPriority.Text = "PRIORITY LEVEL:";
            // 
            // LblAssignedSA
            // 
            this.LblAssignedSA.AutoSize = true;
            this.LblAssignedSA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAssignedSA.Location = new System.Drawing.Point(355, 453);
            this.LblAssignedSA.Name = "LblAssignedSA";
            this.LblAssignedSA.Size = new System.Drawing.Size(87, 15);
            this.LblAssignedSA.TabIndex = 14;
            this.LblAssignedSA.Text = "ASSIGNED SA:";
            // 
            // LblNote
            // 
            this.LblNote.AutoSize = true;
            this.LblNote.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNote.Location = new System.Drawing.Point(355, 334);
            this.LblNote.Name = "LblNote";
            this.LblNote.Size = new System.Drawing.Size(41, 15);
            this.LblNote.TabIndex = 11;
            this.LblNote.Text = "NOTE:";
            // 
            // LblGetID
            // 
            this.LblGetID.AutoSize = true;
            this.LblGetID.Location = new System.Drawing.Point(147, 302);
            this.LblGetID.Name = "LblGetID";
            this.LblGetID.Size = new System.Drawing.Size(15, 16);
            this.LblGetID.TabIndex = 15;
            this.LblGetID.Text = "0";
            // 
            // LblGetTicketID
            // 
            this.LblGetTicketID.AutoSize = true;
            this.LblGetTicketID.Location = new System.Drawing.Point(147, 327);
            this.LblGetTicketID.Name = "LblGetTicketID";
            this.LblGetTicketID.Size = new System.Drawing.Size(15, 16);
            this.LblGetTicketID.TabIndex = 16;
            this.LblGetTicketID.Text = "0";
            // 
            // TxtGetIssue
            // 
            this.TxtGetIssue.Location = new System.Drawing.Point(147, 407);
            this.TxtGetIssue.Name = "TxtGetIssue";
            this.TxtGetIssue.Size = new System.Drawing.Size(178, 22);
            this.TxtGetIssue.TabIndex = 20;
            // 
            // CboPriorityLevel
            // 
            this.CboPriorityLevel.FormattingEnabled = true;
            this.CboPriorityLevel.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.CboPriorityLevel.Location = new System.Drawing.Point(147, 434);
            this.CboPriorityLevel.Name = "CboPriorityLevel";
            this.CboPriorityLevel.Size = new System.Drawing.Size(178, 23);
            this.CboPriorityLevel.TabIndex = 21;
            // 
            // LblGetDept
            // 
            this.LblGetDept.AutoSize = true;
            this.LblGetDept.Location = new System.Drawing.Point(462, 303);
            this.LblGetDept.Name = "LblGetDept";
            this.LblGetDept.Size = new System.Drawing.Size(15, 16);
            this.LblGetDept.TabIndex = 22;
            this.LblGetDept.Text = "0";
            // 
            // TxtGetNote
            // 
            this.TxtGetNote.Location = new System.Drawing.Point(415, 335);
            this.TxtGetNote.Multiline = true;
            this.TxtGetNote.Name = "TxtGetNote";
            this.TxtGetNote.Size = new System.Drawing.Size(211, 51);
            this.TxtGetNote.TabIndex = 23;
            // 
            // CboAssignedSA
            // 
            this.CboAssignedSA.FormattingEnabled = true;
            this.CboAssignedSA.Location = new System.Drawing.Point(446, 450);
            this.CboAssignedSA.Name = "CboAssignedSA";
            this.CboAssignedSA.Size = new System.Drawing.Size(178, 23);
            this.CboAssignedSA.TabIndex = 24;
            // 
            // LblGetFirstName
            // 
            this.LblGetFirstName.AutoSize = true;
            this.LblGetFirstName.Location = new System.Drawing.Point(147, 355);
            this.LblGetFirstName.Name = "LblGetFirstName";
            this.LblGetFirstName.Size = new System.Drawing.Size(15, 16);
            this.LblGetFirstName.TabIndex = 25;
            this.LblGetFirstName.Text = "0";
            // 
            // LblGetLastName
            // 
            this.LblGetLastName.AutoSize = true;
            this.LblGetLastName.Location = new System.Drawing.Point(147, 384);
            this.LblGetLastName.Name = "LblGetLastName";
            this.LblGetLastName.Size = new System.Drawing.Size(15, 16);
            this.LblGetLastName.TabIndex = 26;
            this.LblGetLastName.Text = "0";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(38, 278);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(54, 15);
            this.LblStatus.TabIndex = 27;
            this.LblStatus.Text = "STATUS:";
            // 
            // LblGetStatus
            // 
            this.LblGetStatus.AutoSize = true;
            this.LblGetStatus.Location = new System.Drawing.Point(147, 278);
            this.LblGetStatus.Name = "LblGetStatus";
            this.LblGetStatus.Size = new System.Drawing.Size(15, 16);
            this.LblGetStatus.TabIndex = 28;
            this.LblGetStatus.Text = "0";
            // 
            // FrmSaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Techsist.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 714);
            this.Controls.Add(this.TbcSaUser);
            this.Controls.Add(this.LblLogout);
            this.Controls.Add(this.LblWelcomeSA);
            this.Controls.Add(this.PicLogo);
            this.Name = "FrmSaUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SA User";
            this.Load += new System.EventHandler(this.FrmSaUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.TbcSaUser.ResumeLayout(false);
            this.TbpRequests.ResumeLayout(false);
            this.TbpRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGetRequests)).EndInit();
            this.TbpUserLists.ResumeLayout(false);
            this.TbpUserLists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLogout;
        private System.Windows.Forms.Label LblWelcomeSA;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.TabControl TbcSaUser;
        private System.Windows.Forms.TabPage TbpRequests;
        private System.Windows.Forms.TabPage TbpSATasks;
        private System.Windows.Forms.TabPage TbpSummary;
        private System.Windows.Forms.TabPage TbpUserLists;
        private System.Windows.Forms.DataGridView DgvUserList;
        private System.Windows.Forms.Label LblSelectedID;
        private System.Windows.Forms.DataGridView DgvGetRequests;
        private System.Windows.Forms.Label LblSelectedReqID;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblTicketID;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblAssignedSA;
        private System.Windows.Forms.Label LblNote;
        private System.Windows.Forms.Label LblPriority;
        private System.Windows.Forms.Label LblIssue;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.ComboBox CboAssignedSA;
        private System.Windows.Forms.TextBox TxtGetNote;
        private System.Windows.Forms.Label LblGetDept;
        private System.Windows.Forms.ComboBox CboPriorityLevel;
        private System.Windows.Forms.TextBox TxtGetIssue;
        private System.Windows.Forms.Label LblGetTicketID;
        private System.Windows.Forms.Label LblGetID;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblGetLastName;
        private System.Windows.Forms.Label LblGetFirstName;
        private System.Windows.Forms.Label LblGetStatus;
    }
}