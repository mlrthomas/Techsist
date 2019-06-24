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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.TbcSaUser = new System.Windows.Forms.TabControl();
            this.TbpRequests = new System.Windows.Forms.TabPage();
            this.TbpSATasks = new System.Windows.Forms.TabPage();
            this.TbpSummary = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.TbcSaUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(663, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Logout";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(238, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome SA!";
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
            this.TbcSaUser.Location = new System.Drawing.Point(77, 115);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicLogo);
            this.Name = "FrmSaUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SA User";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.TbcSaUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.TabControl TbcSaUser;
        private System.Windows.Forms.TabPage TbpRequests;
        private System.Windows.Forms.TabPage TbpSATasks;
        private System.Windows.Forms.TabPage TbpSummary;
    }
}