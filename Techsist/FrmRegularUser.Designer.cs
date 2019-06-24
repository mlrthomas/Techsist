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
            this.TbpViewRequests = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.TbcControlUser.SuspendLayout();
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
            this.TbpSubmitRequest.ForeColor = System.Drawing.Color.White;
            this.TbpSubmitRequest.Location = new System.Drawing.Point(4, 24);
            this.TbpSubmitRequest.Name = "TbpSubmitRequest";
            this.TbpSubmitRequest.Padding = new System.Windows.Forms.Padding(3);
            this.TbpSubmitRequest.Size = new System.Drawing.Size(653, 260);
            this.TbpSubmitRequest.TabIndex = 0;
            this.TbpSubmitRequest.Text = "Submit Request";
            // 
            // TbpViewRequests
            // 
            this.TbpViewRequests.Location = new System.Drawing.Point(4, 24);
            this.TbpViewRequests.Name = "TbpViewRequests";
            this.TbpViewRequests.Padding = new System.Windows.Forms.Padding(3);
            this.TbpViewRequests.Size = new System.Drawing.Size(653, 260);
            this.TbpViewRequests.TabIndex = 1;
            this.TbpViewRequests.Text = "View Request";
            this.TbpViewRequests.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.TbcControlUser.ResumeLayout(false);
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
    }
}