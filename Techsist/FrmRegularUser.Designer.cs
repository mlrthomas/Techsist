namespace Techsist
{
    partial class FrmRegularUser
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
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.LblWelcomeUser = new System.Windows.Forms.Label();
            this.LblLogout = new System.Windows.Forms.Label();
            this.TbcControlUser = new System.Windows.Forms.TabControl();
            this.TbpSubmitRequest = new System.Windows.Forms.TabPage();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.CboPriorityLevel = new System.Windows.Forms.ComboBox();
            this.TxtIssue = new System.Windows.Forms.TextBox();
            this.LblNote = new System.Windows.Forms.Label();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.LblPriorityLevel = new System.Windows.Forms.Label();
            this.LblIssue = new System.Windows.Forms.Label();
            this.TbpViewRequests = new System.Windows.Forms.TabPage();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.CboEditPriorityLevel = new System.Windows.Forms.ComboBox();
            this.TxtEditIssue = new System.Windows.Forms.TextBox();
            this.LblEditNote = new System.Windows.Forms.Label();
            this.TxtEditNote = new System.Windows.Forms.TextBox();
            this.LblEditPriorityLevel = new System.Windows.Forms.Label();
            this.LblEditIssue = new System.Windows.Forms.Label();
            this.LblSelectedId = new System.Windows.Forms.Label();
            this.DgvViewRequests = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.TbcControlUser.SuspendLayout();
            this.TbpSubmitRequest.SuspendLayout();
            this.TbpViewRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.Image = global::Techsist.Properties.Resources.Logo;
            this.PicLogo.Location = new System.Drawing.Point(73, 23);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(76, 71);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 2;
            this.PicLogo.TabStop = false;
            // 
            // LblWelcomeUser
            // 
            this.LblWelcomeUser.AutoSize = true;
            this.LblWelcomeUser.BackColor = System.Drawing.Color.Transparent;
            this.LblWelcomeUser.Font = new System.Drawing.Font("Berlin Sans FB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcomeUser.ForeColor = System.Drawing.Color.White;
            this.LblWelcomeUser.Location = new System.Drawing.Point(237, 34);
            this.LblWelcomeUser.Name = "LblWelcomeUser";
            this.LblWelcomeUser.Size = new System.Drawing.Size(348, 58);
            this.LblWelcomeUser.TabIndex = 3;
            this.LblWelcomeUser.Text = "Welcome User!";
            // 
            // LblLogout
            // 
            this.LblLogout.AutoSize = true;
            this.LblLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblLogout.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Underline);
            this.LblLogout.ForeColor = System.Drawing.Color.White;
            this.LblLogout.Location = new System.Drawing.Point(662, 50);
            this.LblLogout.Name = "LblLogout";
            this.LblLogout.Size = new System.Drawing.Size(73, 24);
            this.LblLogout.TabIndex = 4;
            this.LblLogout.Text = "Logout";
            this.LblLogout.Click += new System.EventHandler(this.LblLogout_Click);
            // 
            // TbcControlUser
            // 
            this.TbcControlUser.Controls.Add(this.TbpSubmitRequest);
            this.TbcControlUser.Controls.Add(this.TbpViewRequests);
            this.TbcControlUser.Font = new System.Drawing.Font("Arial", 9.25F);
            this.TbcControlUser.Location = new System.Drawing.Point(73, 132);
            this.TbcControlUser.Multiline = true;
            this.TbcControlUser.Name = "TbcControlUser";
            this.TbcControlUser.SelectedIndex = 0;
            this.TbcControlUser.Size = new System.Drawing.Size(661, 288);
            this.TbcControlUser.TabIndex = 5;
            // 
            // TbpSubmitRequest
            // 
            this.TbpSubmitRequest.BackColor = System.Drawing.Color.SteelBlue;
            this.TbpSubmitRequest.Controls.Add(this.BtnSubmit);
            this.TbpSubmitRequest.Controls.Add(this.CboPriorityLevel);
            this.TbpSubmitRequest.Controls.Add(this.TxtIssue);
            this.TbpSubmitRequest.Controls.Add(this.LblNote);
            this.TbpSubmitRequest.Controls.Add(this.TxtNote);
            this.TbpSubmitRequest.Controls.Add(this.LblPriorityLevel);
            this.TbpSubmitRequest.Controls.Add(this.LblIssue);
            this.TbpSubmitRequest.ForeColor = System.Drawing.Color.White;
            this.TbpSubmitRequest.Location = new System.Drawing.Point(4, 24);
            this.TbpSubmitRequest.Name = "TbpSubmitRequest";
            this.TbpSubmitRequest.Padding = new System.Windows.Forms.Padding(3);
            this.TbpSubmitRequest.Size = new System.Drawing.Size(653, 260);
            this.TbpSubmitRequest.TabIndex = 0;
            this.TbpSubmitRequest.Text = "Submit Request";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubmit.Location = new System.Drawing.Point(530, 215);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(108, 28);
            this.BtnSubmit.TabIndex = 7;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // CboPriorityLevel
            // 
            this.CboPriorityLevel.FormattingEnabled = true;
            this.CboPriorityLevel.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.CboPriorityLevel.Location = new System.Drawing.Point(184, 47);
            this.CboPriorityLevel.Name = "CboPriorityLevel";
            this.CboPriorityLevel.Size = new System.Drawing.Size(302, 23);
            this.CboPriorityLevel.TabIndex = 6;
            // 
            // TxtIssue
            // 
            this.TxtIssue.Location = new System.Drawing.Point(146, 21);
            this.TxtIssue.Name = "TxtIssue";
            this.TxtIssue.Size = new System.Drawing.Size(341, 22);
            this.TxtIssue.TabIndex = 5;
            // 
            // LblNote
            // 
            this.LblNote.AutoSize = true;
            this.LblNote.Location = new System.Drawing.Point(97, 73);
            this.LblNote.Name = "LblNote";
            this.LblNote.Size = new System.Drawing.Size(39, 16);
            this.LblNote.TabIndex = 3;
            this.LblNote.Text = "Note:";
            // 
            // TxtNote
            // 
            this.TxtNote.Location = new System.Drawing.Point(146, 76);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Size = new System.Drawing.Size(340, 135);
            this.TxtNote.TabIndex = 2;
            // 
            // LblPriorityLevel
            // 
            this.LblPriorityLevel.AutoSize = true;
            this.LblPriorityLevel.Location = new System.Drawing.Point(97, 50);
            this.LblPriorityLevel.Name = "LblPriorityLevel";
            this.LblPriorityLevel.Size = new System.Drawing.Size(86, 16);
            this.LblPriorityLevel.TabIndex = 1;
            this.LblPriorityLevel.Text = "Priority Level:";
            // 
            // LblIssue
            // 
            this.LblIssue.AutoSize = true;
            this.LblIssue.Location = new System.Drawing.Point(97, 24);
            this.LblIssue.Name = "LblIssue";
            this.LblIssue.Size = new System.Drawing.Size(43, 16);
            this.LblIssue.TabIndex = 0;
            this.LblIssue.Text = "Issue:";
            // 
            // TbpViewRequests
            // 
            this.TbpViewRequests.Controls.Add(this.BtnDelete);
            this.TbpViewRequests.Controls.Add(this.BtnUpdate);
            this.TbpViewRequests.Controls.Add(this.BtnCancel);
            this.TbpViewRequests.Controls.Add(this.BtnEdit);
            this.TbpViewRequests.Controls.Add(this.CboEditPriorityLevel);
            this.TbpViewRequests.Controls.Add(this.TxtEditIssue);
            this.TbpViewRequests.Controls.Add(this.LblEditNote);
            this.TbpViewRequests.Controls.Add(this.TxtEditNote);
            this.TbpViewRequests.Controls.Add(this.LblEditPriorityLevel);
            this.TbpViewRequests.Controls.Add(this.LblEditIssue);
            this.TbpViewRequests.Controls.Add(this.LblSelectedId);
            this.TbpViewRequests.Controls.Add(this.DgvViewRequests);
            this.TbpViewRequests.Location = new System.Drawing.Point(4, 24);
            this.TbpViewRequests.Name = "TbpViewRequests";
            this.TbpViewRequests.Padding = new System.Windows.Forms.Padding(3);
            this.TbpViewRequests.Size = new System.Drawing.Size(653, 260);
            this.TbpViewRequests.TabIndex = 1;
            this.TbpViewRequests.Text = "View Request";
            this.TbpViewRequests.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Location = new System.Drawing.Point(489, 41);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(108, 28);
            this.BtnUpdate.TabIndex = 16;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.Location = new System.Drawing.Point(489, 156);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(108, 28);
            this.BtnCancel.TabIndex = 15;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Visible = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.Location = new System.Drawing.Point(489, 213);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(108, 28);
            this.BtnEdit.TabIndex = 14;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Visible = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // CboEditPriorityLevel
            // 
            this.CboEditPriorityLevel.FormattingEnabled = true;
            this.CboEditPriorityLevel.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.CboEditPriorityLevel.Location = new System.Drawing.Point(143, 45);
            this.CboEditPriorityLevel.Name = "CboEditPriorityLevel";
            this.CboEditPriorityLevel.Size = new System.Drawing.Size(302, 23);
            this.CboEditPriorityLevel.TabIndex = 13;
            this.CboEditPriorityLevel.Visible = false;
            // 
            // TxtEditIssue
            // 
            this.TxtEditIssue.Location = new System.Drawing.Point(105, 19);
            this.TxtEditIssue.Name = "TxtEditIssue";
            this.TxtEditIssue.Size = new System.Drawing.Size(341, 22);
            this.TxtEditIssue.TabIndex = 12;
            this.TxtEditIssue.Visible = false;
            // 
            // LblEditNote
            // 
            this.LblEditNote.AutoSize = true;
            this.LblEditNote.Location = new System.Drawing.Point(56, 71);
            this.LblEditNote.Name = "LblEditNote";
            this.LblEditNote.Size = new System.Drawing.Size(39, 16);
            this.LblEditNote.TabIndex = 11;
            this.LblEditNote.Text = "Note:";
            this.LblEditNote.Visible = false;
            // 
            // TxtEditNote
            // 
            this.TxtEditNote.Location = new System.Drawing.Point(105, 74);
            this.TxtEditNote.Multiline = true;
            this.TxtEditNote.Name = "TxtEditNote";
            this.TxtEditNote.Size = new System.Drawing.Size(340, 135);
            this.TxtEditNote.TabIndex = 10;
            this.TxtEditNote.Visible = false;
            // 
            // LblEditPriorityLevel
            // 
            this.LblEditPriorityLevel.AutoSize = true;
            this.LblEditPriorityLevel.Location = new System.Drawing.Point(56, 48);
            this.LblEditPriorityLevel.Name = "LblEditPriorityLevel";
            this.LblEditPriorityLevel.Size = new System.Drawing.Size(86, 16);
            this.LblEditPriorityLevel.TabIndex = 9;
            this.LblEditPriorityLevel.Text = "Priority Level:";
            this.LblEditPriorityLevel.Visible = false;
            // 
            // LblEditIssue
            // 
            this.LblEditIssue.AutoSize = true;
            this.LblEditIssue.Location = new System.Drawing.Point(56, 22);
            this.LblEditIssue.Name = "LblEditIssue";
            this.LblEditIssue.Size = new System.Drawing.Size(43, 16);
            this.LblEditIssue.TabIndex = 8;
            this.LblEditIssue.Text = "Issue:";
            this.LblEditIssue.Visible = false;
            // 
            // LblSelectedId
            // 
            this.LblSelectedId.AutoSize = true;
            this.LblSelectedId.Location = new System.Drawing.Point(27, 207);
            this.LblSelectedId.Name = "LblSelectedId";
            this.LblSelectedId.Size = new System.Drawing.Size(69, 16);
            this.LblSelectedId.TabIndex = 1;
            this.LblSelectedId.Text = "SelectedId";
            // 
            // DgvViewRequests
            // 
            this.DgvViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvViewRequests.Location = new System.Drawing.Point(27, 23);
            this.DgvViewRequests.Name = "DgvViewRequests";
            this.DgvViewRequests.Size = new System.Drawing.Size(608, 172);
            this.DgvViewRequests.TabIndex = 0;
            this.DgvViewRequests.SelectionChanged += new System.EventHandler(this.DgvViewRequests_SelectionChanged);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Location = new System.Drawing.Point(363, 213);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(108, 28);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmRegularUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Techsist.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbcControlUser);
            this.Controls.Add(this.LblLogout);
            this.Controls.Add(this.LblWelcomeUser);
            this.Controls.Add(this.PicLogo);
            this.Name = "FrmRegularUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regular User";
            this.Load += new System.EventHandler(this.FrmRegularUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.TbcControlUser.ResumeLayout(false);
            this.TbpSubmitRequest.ResumeLayout(false);
            this.TbpSubmitRequest.PerformLayout();
            this.TbpViewRequests.ResumeLayout(false);
            this.TbpViewRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Label LblWelcomeUser;
        private System.Windows.Forms.Label LblLogout;
        private System.Windows.Forms.TabControl TbcControlUser;
        private System.Windows.Forms.TabPage TbpSubmitRequest;
        private System.Windows.Forms.TabPage TbpViewRequests;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.ComboBox CboPriorityLevel;
        private System.Windows.Forms.TextBox TxtIssue;
        private System.Windows.Forms.Label LblNote;
        private System.Windows.Forms.TextBox TxtNote;
        private System.Windows.Forms.Label LblPriorityLevel;
        private System.Windows.Forms.Label LblIssue;
        private System.Windows.Forms.DataGridView DgvViewRequests;
        private System.Windows.Forms.Label LblSelectedId;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.ComboBox CboEditPriorityLevel;
        private System.Windows.Forms.TextBox TxtEditIssue;
        private System.Windows.Forms.Label LblEditNote;
        private System.Windows.Forms.TextBox TxtEditNote;
        private System.Windows.Forms.Label LblEditPriorityLevel;
        private System.Windows.Forms.Label LblEditIssue;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
    }
}