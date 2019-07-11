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
            this.TbcSaUser.Size = new System.Drawing.Size(734, 283);
            this.TbcSaUser.TabIndex = 8;
            // 
            // TbpRequests
            // 
            this.TbpRequests.BackColor = System.Drawing.Color.Teal;
            this.TbpRequests.Controls.Add(this.DgvGetRequests);
            this.TbpRequests.Location = new System.Drawing.Point(4, 24);
            this.TbpRequests.Name = "TbpRequests";
            this.TbpRequests.Padding = new System.Windows.Forms.Padding(3);
            this.TbpRequests.Size = new System.Drawing.Size(726, 255);
            this.TbpRequests.TabIndex = 0;
            this.TbpRequests.Text = "Requests";
            // 
            // DgvGetRequests
            // 
            this.DgvGetRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGetRequests.Location = new System.Drawing.Point(17, 22);
            this.DgvGetRequests.Name = "DgvGetRequests";
            this.DgvGetRequests.Size = new System.Drawing.Size(693, 217);
            this.DgvGetRequests.TabIndex = 0;
            // 
            // TbpSATasks
            // 
            this.TbpSATasks.BackColor = System.Drawing.Color.Teal;
            this.TbpSATasks.Location = new System.Drawing.Point(4, 24);
            this.TbpSATasks.Name = "TbpSATasks";
            this.TbpSATasks.Padding = new System.Windows.Forms.Padding(3);
            this.TbpSATasks.Size = new System.Drawing.Size(726, 255);
            this.TbpSATasks.TabIndex = 1;
            this.TbpSATasks.Text = "SA Tasks";
            // 
            // TbpSummary
            // 
            this.TbpSummary.BackColor = System.Drawing.Color.Teal;
            this.TbpSummary.Location = new System.Drawing.Point(4, 24);
            this.TbpSummary.Name = "TbpSummary";
            this.TbpSummary.Size = new System.Drawing.Size(726, 255);
            this.TbpSummary.TabIndex = 2;
            this.TbpSummary.Text = "Summary";
            // 
            // TbpUserLists
            // 
            this.TbpUserLists.Controls.Add(this.LblSelectedID);
            this.TbpUserLists.Controls.Add(this.DgvUserList);
            this.TbpUserLists.Location = new System.Drawing.Point(4, 24);
            this.TbpUserLists.Name = "TbpUserLists";
            this.TbpUserLists.Size = new System.Drawing.Size(726, 255);
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
            // FrmSaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Techsist.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}