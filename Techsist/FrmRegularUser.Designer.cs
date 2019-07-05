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
            this.DgvViewRequests = new System.Windows.Forms.DataGridView();
            this.LblSelectedIssue = new System.Windows.Forms.Label();
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
            this.TbpViewRequests.Controls.Add(this.LblSelectedIssue);
            this.TbpViewRequests.Controls.Add(this.DgvViewRequests);
            this.TbpViewRequests.Location = new System.Drawing.Point(4, 24);
            this.TbpViewRequests.Name = "TbpViewRequests";
            this.TbpViewRequests.Padding = new System.Windows.Forms.Padding(3);
            this.TbpViewRequests.Size = new System.Drawing.Size(653, 260);
            this.TbpViewRequests.TabIndex = 1;
            this.TbpViewRequests.Text = "View Request";
            this.TbpViewRequests.UseVisualStyleBackColor = true;
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
            // LblSelectedIssue
            // 
            this.LblSelectedIssue.AutoSize = true;
            this.LblSelectedIssue.Location = new System.Drawing.Point(27, 207);
            this.LblSelectedIssue.Name = "LblSelectedIssue";
            this.LblSelectedIssue.Size = new System.Drawing.Size(90, 16);
            this.LblSelectedIssue.TabIndex = 1;
            this.LblSelectedIssue.Text = "SelectedIssue";
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
        private System.Windows.Forms.Label LblSelectedIssue;
    }
}