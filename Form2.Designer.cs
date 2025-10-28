namespace ForditoProgram3
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbRegister = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txCPassword = new System.Windows.Forms.TextBox();
            this.lbCPassword = new System.Windows.Forms.Label();
            this.btRegist = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.cbSPassword = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "picsa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbRegister.Location = new System.Drawing.Point(69, 91);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(154, 21);
            this.lbRegister.TabIndex = 2;
            this.lbRegister.Text = "Registration";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbTitle.Location = new System.Drawing.Point(36, 34);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(237, 36);
            this.lbTitle.TabIndex = 47;
            this.lbTitle.Text = "GP\'s Translator";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.ForeColor = System.Drawing.Color.Gray;
            this.lbUsername.Location = new System.Drawing.Point(36, 142);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(77, 16);
            this.lbUsername.TabIndex = 48;
            this.lbUsername.Text = "Username";
            // 
            // txUsername
            // 
            this.txUsername.BackColor = System.Drawing.Color.LightGray;
            this.txUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txUsername.Location = new System.Drawing.Point(36, 161);
            this.txUsername.Multiline = true;
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(234, 28);
            this.txUsername.TabIndex = 49;
            // 
            // txPassword
            // 
            this.txPassword.BackColor = System.Drawing.Color.LightGray;
            this.txPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPassword.Location = new System.Drawing.Point(36, 238);
            this.txPassword.Multiline = true;
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '*';
            this.txPassword.Size = new System.Drawing.Size(234, 28);
            this.txPassword.TabIndex = 51;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.ForeColor = System.Drawing.Color.Gray;
            this.lbPassword.Location = new System.Drawing.Point(36, 219);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(71, 15);
            this.lbPassword.TabIndex = 50;
            this.lbPassword.Text = "Password";
            // 
            // txCPassword
            // 
            this.txCPassword.BackColor = System.Drawing.Color.LightGray;
            this.txCPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txCPassword.Location = new System.Drawing.Point(36, 317);
            this.txCPassword.Multiline = true;
            this.txCPassword.Name = "txCPassword";
            this.txCPassword.PasswordChar = '*';
            this.txCPassword.Size = new System.Drawing.Size(234, 28);
            this.txCPassword.TabIndex = 53;
            // 
            // lbCPassword
            // 
            this.lbCPassword.AutoSize = true;
            this.lbCPassword.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCPassword.ForeColor = System.Drawing.Color.Gray;
            this.lbCPassword.Location = new System.Drawing.Point(36, 298);
            this.lbCPassword.Name = "lbCPassword";
            this.lbCPassword.Size = new System.Drawing.Size(135, 15);
            this.lbCPassword.TabIndex = 52;
            this.lbCPassword.Text = "Confirm Password";
            // 
            // btRegist
            // 
            this.btRegist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btRegist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegist.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btRegist.ForeColor = System.Drawing.Color.White;
            this.btRegist.Location = new System.Drawing.Point(46, 381);
            this.btRegist.Name = "btRegist";
            this.btRegist.Size = new System.Drawing.Size(208, 32);
            this.btRegist.TabIndex = 54;
            this.btRegist.Text = "Registration";
            this.btRegist.UseVisualStyleBackColor = false;
            this.btRegist.Click += new System.EventHandler(this.btRegist_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.White;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btClear.Location = new System.Drawing.Point(46, 419);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(208, 32);
            this.btClear.TabIndex = 55;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // cbSPassword
            // 
            this.cbSPassword.AutoSize = true;
            this.cbSPassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.cbSPassword.Location = new System.Drawing.Point(143, 355);
            this.cbSPassword.Name = "cbSPassword";
            this.cbSPassword.Size = new System.Drawing.Size(127, 20);
            this.cbSPassword.TabIndex = 56;
            this.cbSPassword.Text = "Show Password";
            this.cbSPassword.UseVisualStyleBackColor = true;
            this.cbSPassword.CheckedChanged += new System.EventHandler(this.cbSPassword_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(55, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 15);
            this.label2.TabIndex = 57;
            this.label2.Text = "Already Have an Account";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbLogin.Location = new System.Drawing.Point(79, 489);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(138, 18);
            this.lbLogin.TabIndex = 58;
            this.lbLogin.Text = "Back to LOGIN";
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(294, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSPassword);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btRegist);
            this.Controls.Add(this.txCPassword);
            this.Controls.Add(this.lbCPassword);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistration";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Label lbRegister;
        private Label lbTitle;
        private Label lbUsername;
        private TextBox txUsername;
        private TextBox txPassword;
        private Label lbPassword;
        private TextBox txCPassword;
        private Label lbCPassword;
        private Button btRegist;
        private Button btClear;
        private CheckBox cbSPassword;
        private Label label2;
        private Label lbLogin;
        private PictureBox pictureBox1;
    }
}