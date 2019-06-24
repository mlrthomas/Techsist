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
            this.TbpSATasks = new System.Windows.Forms.TabPage();
            this.TbpSummary = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.TbcSaUser.SuspendLayout();
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
            this.TbcSaUser.Font = new System.Drawing.Font("Arial", 9.25F);
            this.TbcSaUser.Location = new System.Drawing.Point(78, 115);
            this.TbcSaUser.Name = "TbcSaUser";
            this.TbcSaUser.SelectedIndex = 0;
            this.TbcSaUser.Size = new System.Drawing.Size(658, 283);
            this.TbcSaUser.TabIndex = 8;
            // 
            // TbpRequests
            // 
            this.TbpRequests.BackColor = System.Drawing.Color.Teal;
            this.TbpRequests.Location = new System.Drawing.Point(4, 24);
            this.TbpRequests.Name = "TbpRequests";
            this.TbpRequests.Padding = new System.Windows.Forms.Padding(3);
            this.TbpRequests.Size = new System.Drawing.Size(650, 255);
            this.TbpRequests.TabIndex = 0;
            this.TbpRequests.Text = "Requests";
            // 
            // TbpSATasks
            // 
            this.TbpSATasks.BackColor = System.Drawing.Color.Teal;
            this.TbpSATasks.Location = new System.Drawing.Point(4, 24);
            this.TbpSATasks.Name = "TbpSATasks";
            this.TbpSATasks.Padding = new System.Windows.Forms.Padding(3);
            this.TbpSATasks.Size = new System.Drawing.Size(650, 255);
            this.TbpSATasks.TabIndex = 1;
            this.TbpSATasks.Text = "SA Tasks";
            // 
            // TbpSummary
            // 
            this.TbpSummary.BackColor = System.Drawing.Color.Teal;
            this.TbpSummary.Location = new System.Drawing.Point(4, 24);
            this.TbpSummary.Name = "TbpSummary";
            this.TbpSummary.Size = new System.Drawing.Size(650, 255);
            this.TbpSummary.TabIndex = 2;
            this.TbpSummary.Text = "Summary";
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
    }
}