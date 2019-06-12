namespace Techsist
{
    partial class FrmRegister
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
            this.LblHaveAccount = new System.Windows.Forms.Label();
            this.GrpSignIn = new System.Windows.Forms.GroupBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.CboDepartment = new System.Windows.Forms.ComboBox();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.LblPosition = new System.Windows.Forms.Label();
            this.CboPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.GrpSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.Image = global::Techsist.Properties.Resources.Logo;
            this.PicLogo.Location = new System.Drawing.Point(338, 16);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(120, 116);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 1;
            this.PicLogo.TabStop = false;
            // 
            // LblHaveAccount
            // 
            this.LblHaveAccount.AutoSize = true;
            this.LblHaveAccount.BackColor = System.Drawing.Color.Transparent;
            this.LblHaveAccount.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHaveAccount.ForeColor = System.Drawing.Color.White;
            this.LblHaveAccount.Location = new System.Drawing.Point(335, 377);
            this.LblHaveAccount.Name = "LblHaveAccount";
            this.LblHaveAccount.Size = new System.Drawing.Size(150, 15);
            this.LblHaveAccount.TabIndex = 9;
            this.LblHaveAccount.Text = "Already have an account? Sign In!";
            // 
            // GrpSignIn
            // 
            this.GrpSignIn.BackColor = System.Drawing.Color.Transparent;
            this.GrpSignIn.Controls.Add(this.LblPosition);
            this.GrpSignIn.Controls.Add(this.CboPosition);
            this.GrpSignIn.Controls.Add(this.LblDepartment);
            this.GrpSignIn.Controls.Add(this.CboDepartment);
            this.GrpSignIn.Controls.Add(this.textBox1);
            this.GrpSignIn.Controls.Add(this.LblPassword);
            this.GrpSignIn.Controls.Add(this.TxtEmail);
            this.GrpSignIn.Controls.Add(this.LblEmail);
            this.GrpSignIn.Controls.Add(this.TxtLastName);
            this.GrpSignIn.Controls.Add(this.LblLastName);
            this.GrpSignIn.Controls.Add(this.BtnRegister);
            this.GrpSignIn.Controls.Add(this.TxtFirstName);
            this.GrpSignIn.Controls.Add(this.LblFirstName);
            this.GrpSignIn.Location = new System.Drawing.Point(66, 150);
            this.GrpSignIn.Name = "GrpSignIn";
            this.GrpSignIn.Size = new System.Drawing.Size(686, 224);
            this.GrpSignIn.TabIndex = 8;
            this.GrpSignIn.TabStop = false;
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(591, 189);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(80, 27);
            this.BtnRegister.TabIndex = 5;
            this.BtnRegister.Text = "REGISTER";
            this.BtnRegister.UseVisualStyleBackColor = false;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(22, 40);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(252, 20);
            this.TxtFirstName.TabIndex = 3;
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstName.ForeColor = System.Drawing.Color.White;
            this.LblFirstName.Location = new System.Drawing.Point(19, 24);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(68, 15);
            this.LblFirstName.TabIndex = 1;
            this.LblFirstName.Text = "First Name";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(22, 86);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(252, 20);
            this.TxtLastName.TabIndex = 7;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastName.ForeColor = System.Drawing.Color.White;
            this.LblLastName.Location = new System.Drawing.Point(19, 70);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(68, 15);
            this.LblLastName.TabIndex = 6;
            this.LblLastName.Text = "Last Name";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(22, 131);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(252, 20);
            this.TxtEmail.TabIndex = 9;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.White;
            this.LblEmail.Location = new System.Drawing.Point(19, 115);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(38, 15);
            this.LblEmail.TabIndex = 8;
            this.LblEmail.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 11;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.White;
            this.LblPassword.Location = new System.Drawing.Point(19, 157);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(65, 15);
            this.LblPassword.TabIndex = 10;
            this.LblPassword.Text = "Password";
            // 
            // CboDepartment
            // 
            this.CboDepartment.FormattingEnabled = true;
            this.CboDepartment.Items.AddRange(new object[] {
            "Accounting",
            "Configuration ",
            "Cybersecurity",
            "Others",
            "Quality Assuarance",
            "Software Developer",
            "System Administrator"});
            this.CboDepartment.Location = new System.Drawing.Point(365, 39);
            this.CboDepartment.Name = "CboDepartment";
            this.CboDepartment.Size = new System.Drawing.Size(211, 21);
            this.CboDepartment.Sorted = true;
            this.CboDepartment.TabIndex = 12;
            this.CboDepartment.Text = "Select Department";
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepartment.ForeColor = System.Drawing.Color.White;
            this.LblDepartment.Location = new System.Drawing.Point(362, 24);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(74, 15);
            this.LblDepartment.TabIndex = 13;
            this.LblDepartment.Text = "Department";
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPosition.ForeColor = System.Drawing.Color.White;
            this.LblPosition.Location = new System.Drawing.Point(362, 70);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(53, 15);
            this.LblPosition.TabIndex = 15;
            this.LblPosition.Text = "Position";
            // 
            // CboPosition
            // 
            this.CboPosition.FormattingEnabled = true;
            this.CboPosition.Items.AddRange(new object[] {
            "Accounting",
            "Configuration ",
            "Cybersecurity",
            "Others",
            "Quality Assuarance",
            "Software Developer",
            "System Administrator"});
            this.CboPosition.Location = new System.Drawing.Point(365, 85);
            this.CboPosition.Name = "CboPosition";
            this.CboPosition.Size = new System.Drawing.Size(211, 21);
            this.CboPosition.Sorted = true;
            this.CboPosition.TabIndex = 14;
            this.CboPosition.Text = "Select Position";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Techsist.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblHaveAccount);
            this.Controls.Add(this.GrpSignIn);
            this.Controls.Add(this.PicLogo);
            this.Name = "FrmRegister";
            this.Text = "Register Form";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.GrpSignIn.ResumeLayout(false);
            this.GrpSignIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Label LblHaveAccount;
        private System.Windows.Forms.GroupBox GrpSignIn;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.ComboBox CboDepartment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.ComboBox CboPosition;
    }
}