namespace BuildYourMenu.WebFormsUI
{
    partial class UserControl1
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
            btnGuest = new Button();
            gbxLogin = new GroupBox();
            tbxPassLogin = new TextBox();
            lblPassLogin = new Label();
            lblUserNameLogin = new Label();
            cbxUsers = new ComboBox();
            btnLogin = new Button();
            gbxRegister = new GroupBox();
            tbxEmailRegister = new TextBox();
            lblEmailRegister = new Label();
            tbxUsernameRegister = new TextBox();
            tbxPassRegister = new TextBox();
            lblPassRegister = new Label();
            lblUsernameRegister = new Label();
            btnRegister = new Button();
            gbxLogin.SuspendLayout();
            gbxRegister.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuest
            // 
            btnGuest.Location = new Point(12, 246);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(615, 68);
            btnGuest.TabIndex = 0;
            btnGuest.Text = "Misafir Girişi";
            btnGuest.UseVisualStyleBackColor = true;
            // 
            // gbxLogin
            // 
            gbxLogin.Controls.Add(tbxPassLogin);
            gbxLogin.Controls.Add(lblPassLogin);
            gbxLogin.Controls.Add(lblUserNameLogin);
            gbxLogin.Controls.Add(cbxUsers);
            gbxLogin.Controls.Add(btnLogin);
            gbxLogin.Location = new Point(12, 12);
            gbxLogin.Name = "gbxLogin";
            gbxLogin.Size = new Size(297, 219);
            gbxLogin.TabIndex = 1;
            gbxLogin.TabStop = false;
            gbxLogin.Text = "Giriş Yap";
            // 
            // tbxPassLogin
            // 
            tbxPassLogin.Location = new Point(113, 97);
            tbxPassLogin.Name = "tbxPassLogin";
            tbxPassLogin.Size = new Size(165, 23);
            tbxPassLogin.TabIndex = 5;
            // 
            // lblPassLogin
            // 
            lblPassLogin.AutoSize = true;
            lblPassLogin.Location = new Point(16, 100);
            lblPassLogin.Name = "lblPassLogin";
            lblPassLogin.Size = new Size(39, 15);
            lblPassLogin.TabIndex = 4;
            lblPassLogin.Text = "Şifre : ";
            // 
            // lblUserNameLogin
            // 
            lblUserNameLogin.AutoSize = true;
            lblUserNameLogin.Location = new Point(16, 62);
            lblUserNameLogin.Name = "lblUserNameLogin";
            lblUserNameLogin.Size = new Size(82, 15);
            lblUserNameLogin.TabIndex = 2;
            lblUserNameLogin.Text = "Kullanıcı Adı : ";
            // 
            // cbxUsers
            // 
            cbxUsers.FormattingEnabled = true;
            cbxUsers.Location = new Point(113, 59);
            cbxUsers.Name = "cbxUsers";
            cbxUsers.Size = new Size(165, 23);
            cbxUsers.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(23, 143);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(255, 50);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // gbxRegister
            // 
            gbxRegister.Controls.Add(tbxEmailRegister);
            gbxRegister.Controls.Add(lblEmailRegister);
            gbxRegister.Controls.Add(tbxUsernameRegister);
            gbxRegister.Controls.Add(tbxPassRegister);
            gbxRegister.Controls.Add(lblPassRegister);
            gbxRegister.Controls.Add(lblUsernameRegister);
            gbxRegister.Controls.Add(btnRegister);
            gbxRegister.Location = new Point(330, 12);
            gbxRegister.Name = "gbxRegister";
            gbxRegister.Size = new Size(297, 219);
            gbxRegister.TabIndex = 6;
            gbxRegister.TabStop = false;
            gbxRegister.Text = "Kayıt Ol";
            // 
            // tbxEmailRegister
            // 
            tbxEmailRegister.Location = new Point(113, 109);
            tbxEmailRegister.Name = "tbxEmailRegister";
            tbxEmailRegister.Size = new Size(165, 23);
            tbxEmailRegister.TabIndex = 8;
            // 
            // lblEmailRegister
            // 
            lblEmailRegister.AutoSize = true;
            lblEmailRegister.Location = new Point(16, 112);
            lblEmailRegister.Name = "lblEmailRegister";
            lblEmailRegister.Size = new Size(50, 15);
            lblEmailRegister.TabIndex = 7;
            lblEmailRegister.Text = "E-Mail : ";
            // 
            // tbxUsernameRegister
            // 
            tbxUsernameRegister.Location = new Point(113, 33);
            tbxUsernameRegister.Name = "tbxUsernameRegister";
            tbxUsernameRegister.Size = new Size(165, 23);
            tbxUsernameRegister.TabIndex = 6;
            // 
            // tbxPassRegister
            // 
            tbxPassRegister.Location = new Point(113, 71);
            tbxPassRegister.Name = "tbxPassRegister";
            tbxPassRegister.Size = new Size(165, 23);
            tbxPassRegister.TabIndex = 5;
            // 
            // lblPassRegister
            // 
            lblPassRegister.AutoSize = true;
            lblPassRegister.Location = new Point(16, 74);
            lblPassRegister.Name = "lblPassRegister";
            lblPassRegister.Size = new Size(39, 15);
            lblPassRegister.TabIndex = 4;
            lblPassRegister.Text = "Şifre : ";
            // 
            // lblUsernameRegister
            // 
            lblUsernameRegister.AutoSize = true;
            lblUsernameRegister.Location = new Point(16, 36);
            lblUsernameRegister.Name = "lblUsernameRegister";
            lblUsernameRegister.Size = new Size(82, 15);
            lblUsernameRegister.TabIndex = 2;
            lblUsernameRegister.Text = "Kullanıcı Adı : ";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(23, 143);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(255, 50);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 324);
            Controls.Add(gbxRegister);
            Controls.Add(gbxLogin);
            Controls.Add(btnGuest);
            Name = "UserControl1";
            Text = "UserControl";
            FormClosing += UserControl1_FormClosing;
            Load += UserControl1_Load;
            gbxLogin.ResumeLayout(false);
            gbxLogin.PerformLayout();
            gbxRegister.ResumeLayout(false);
            gbxRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuest;
        private GroupBox gbxLogin;
        private TextBox tbxPassLogin;
        private Label lblPassLogin;
        private Label lblUserNameLogin;
        private ComboBox cbxUsers;
        private Button btnLogin;
        private GroupBox gbxRegister;
        private TextBox tbxEmailRegister;
        private Label lblEmailRegister;
        private TextBox tbxUsernameRegister;
        private TextBox tbxPassRegister;
        private Label lblPassRegister;
        private Label lblUsernameRegister;
        private Button btnRegister;
    }
}