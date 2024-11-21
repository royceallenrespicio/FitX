namespace FitX
{
    partial class LoginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            panel1 = new Panel();
            registerBtn = new Button();
            showPassword = new CheckBox();
            forgotPasswordBtn = new Label();
            passwordField = new TextBox();
            loginBtn = new Button();
            passwordLabel = new Label();
            emailField = new TextBox();
            emailLabel = new Label();
            titleLabel = new Label();
            loginImg = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loginImg).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(registerBtn);
            panel1.Controls.Add(showPassword);
            panel1.Controls.Add(forgotPasswordBtn);
            panel1.Controls.Add(passwordField);
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(emailField);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(titleLabel);
            panel1.Location = new Point(422, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 327);
            panel1.TabIndex = 3;
            // 
            // registerBtn
            // 
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(86, 280);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(145, 22);
            registerBtn.TabIndex = 13;
            registerBtn.Text = "Don't have an account?";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showPassword.ForeColor = Color.White;
            showPassword.Location = new Point(29, 192);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(109, 19);
            showPassword.TabIndex = 12;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // forgotPasswordBtn
            // 
            forgotPasswordBtn.AutoSize = true;
            forgotPasswordBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forgotPasswordBtn.ForeColor = Color.White;
            forgotPasswordBtn.Location = new Point(193, 193);
            forgotPasswordBtn.Name = "forgotPasswordBtn";
            forgotPasswordBtn.Size = new Size(104, 15);
            forgotPasswordBtn.TabIndex = 10;
            forgotPasswordBtn.Text = "Forgot Password?";
            forgotPasswordBtn.Click += forgotPasswordBtn_Click;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(29, 167);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(268, 23);
            passwordField.TabIndex = 8;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.Location = new Point(111, 246);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(96, 28);
            loginBtn.TabIndex = 9;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(29, 144);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(80, 20);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            // 
            // emailField
            // 
            emailField.Location = new Point(29, 106);
            emailField.Name = "emailField";
            emailField.Size = new Size(268, 23);
            emailField.TabIndex = 6;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(29, 83);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(51, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(129, 26);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(68, 37);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "FitX";
            // 
            // loginImg
            // 
            loginImg.Image = (Image)resources.GetObject("loginImg.Image");
            loginImg.Location = new Point(-2, -1);
            loginImg.Name = "loginImg";
            loginImg.Size = new Size(381, 581);
            loginImg.SizeMode = PictureBoxSizeMode.StretchImage;
            loginImg.TabIndex = 4;
            loginImg.TabStop = false;
            // 
            // LoginPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 580);
            Controls.Add(loginImg);
            Controls.Add(panel1);
            Name = "LoginPanel";
            Text = "LoginPanel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loginImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label forgotPasswordBtn;
        private Button loginBtn;
        private TextBox passwordField;
        private Label passwordLabel;
        private TextBox emailField;
        private Label emailLabel;
        private Label titleLabel;
        private CheckBox showPassword;
        private PictureBox loginImg;
        private Button registerBtn;
    }
}