namespace ForditoProgram3
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSPassword = new System.Windows.Forms.CheckBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btRegist = new System.Windows.Forms.Button();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(77, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 68;
            this.label3.Text = "Create Account";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(58, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 15);
            this.label2.TabIndex = 67;
            this.label2.Text = "Don\'t Have Account yet";
            // 
            // cbSPassword
            // 
            this.cbSPassword.AutoSize = true;
            this.cbSPassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.cbSPassword.Location = new System.Drawing.Point(130, 278);
            this.cbSPassword.Name = "cbSPassword";
            this.cbSPassword.Size = new System.Drawing.Size(127, 20);
            this.cbSPassword.TabIndex = 66;
            this.cbSPassword.Text = "Show Password";
            this.cbSPassword.UseVisualStyleBackColor = true;
            this.cbSPassword.CheckedChanged += new System.EventHandler(this.cbSPassword_CheckedChanged);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.White;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btClear.Location = new System.Drawing.Point(49, 362);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(208, 32);
            this.btClear.TabIndex = 65;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btRegist
            // 
            this.btRegist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btRegist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegist.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btRegist.ForeColor = System.Drawing.Color.White;
            this.btRegist.Location = new System.Drawing.Point(49, 324);
            this.btRegist.Name = "btRegist";
            this.btRegist.Size = new System.Drawing.Size(208, 32);
            this.btRegist.TabIndex = 64;
            this.btRegist.Text = "Login";
            this.btRegist.UseVisualStyleBackColor = false;
            this.btRegist.Click += new System.EventHandler(this.btRegist_Click);
            // 
            // txPassword
            // 
            this.txPassword.BackColor = System.Drawing.Color.LightGray;
            this.txPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPassword.Location = new System.Drawing.Point(33, 228);
            this.txPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '*';
            this.txPassword.Size = new System.Drawing.Size(234, 16);
            this.txPassword.TabIndex = 62;
            this.txPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterle3);
            // 
            // txUsername
            // 
            this.txUsername.BackColor = System.Drawing.Color.LightGray;
            this.txUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txUsername.Location = new System.Drawing.Point(33, 167);
            this.txUsername.Margin = new System.Windows.Forms.Padding(6);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(234, 16);
            this.txUsername.TabIndex = 61;
            this.txUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterle2);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbTitle.Location = new System.Drawing.Point(33, 33);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(237, 36);
            this.lbTitle.TabIndex = 60;
            this.lbTitle.Text = "GP\'s Translator";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbLogin.Location = new System.Drawing.Point(114, 83);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(70, 21);
            this.lbLogin.TabIndex = 59;
            this.lbLogin.Text = "Login";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.ForeColor = System.Drawing.Color.Gray;
            this.lbPassword.Location = new System.Drawing.Point(29, 210);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(71, 15);
            this.lbPassword.TabIndex = 70;
            this.lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.ForeColor = System.Drawing.Color.Gray;
            this.lbUsername.Location = new System.Drawing.Point(33, 148);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(77, 16);
            this.lbUsername.TabIndex = 69;
            this.lbUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(33, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 72;
            this.label1.Text = "AutoFill";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(294, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSPassword);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btRegist);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.enterle);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private CheckBox cbSPassword;
        private Button btClear;
        private Button btRegist;
        private TextBox txPassword;
        private TextBox txUsername;
        private Label lbTitle;
        private Label lbLogin;
        private Label lbPassword;
        private Label lbUsername;
        private PictureBox pictureBox1;
        private Label label1;
    }
}