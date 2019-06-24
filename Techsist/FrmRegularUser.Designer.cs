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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(237, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome User!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(662, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Logout";
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
            this.TbpViewRequests.Location = new System.Drawing.Point(4, 26);
            this.TbpViewRequests.Name = "TbpViewRequests";
            this.TbpViewRequests.Padding = new System.Windows.Forms.Padding(3);
            this.TbpViewRequests.Size = new System.Drawing.Size(653, 258);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl TbcControlUser;
        private System.Windows.Forms.TabPage TbpSubmitRequest;
        private System.Windows.Forms.TabPage TbpViewRequests;
    }
}