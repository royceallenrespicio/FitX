namespace FitX
{
    partial class SignupPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupPanel));
            panel1 = new Panel();
            confirmPasswordField = new TextBox();
            confirmPasswordLabel = new Label();
            loginBtn = new Button();
            showPassword = new CheckBox();
            titleLabel = new Label();
            registerBtn = new Button();
            passwordField = new TextBox();
            passwordLabel = new Label();
            emailField = new TextBox();
            emailLabel = new Label();
            lastNameField = new TextBox();
            lastNameLabel = new Label();
            firstNameField = new TextBox();
            firstNameLabel = new Label();
            signupImg = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signupImg).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(confirmPasswordField);
            panel1.Controls.Add(confirmPasswordLabel);
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(showPassword);
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(registerBtn);
            panel1.Controls.Add(passwordField);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(emailField);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(lastNameField);
            panel1.Controls.Add(lastNameLabel);
            panel1.Controls.Add(firstNameField);
            panel1.Controls.Add(firstNameLabel);
            panel1.Location = new Point(425, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 495);
            panel1.TabIndex = 0;
            // 
            // confirmPasswordField
            // 
            confirmPasswordField.Location = new Point(32, 336);
            confirmPasswordField.Name = "confirmPasswordField";
            confirmPasswordField.Size = new Size(268, 23);
            confirmPasswordField.TabIndex = 13;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmPasswordLabel.ForeColor = Color.White;
            confirmPasswordLabel.Location = new Point(32, 313);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(141, 20);
            confirmPasswordLabel.TabIndex = 12;
            confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // loginBtn
            // 
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(83, 446);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(162, 28);
            loginBtn.TabIndex = 11;
            loginBtn.Text = "Already have an account?";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showPassword.ForeColor = Color.White;
            showPassword.Location = new Point(191, 365);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(109, 19);
            showPassword.TabIndex = 10;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(126, 32);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(68, 37);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "FitX";
            // 
            // registerBtn
            // 
            registerBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.Location = new Point(113, 412);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(96, 28);
            registerBtn.TabIndex = 9;
            registerBtn.Text = "REGISTER";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(32, 278);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(268, 23);
            passwordField.TabIndex = 8;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(32, 255);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(80, 20);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            // 
            // emailField
            // 
            emailField.Location = new Point(32, 220);
            emailField.Name = "emailField";
            emailField.Size = new Size(268, 23);
            emailField.TabIndex = 6;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(32, 197);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(51, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // lastNameField
            // 
            lastNameField.Location = new Point(32, 162);
            lastNameField.Name = "lastNameField";
            lastNameField.Size = new Size(268, 23);
            lastNameField.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = Color.White;
            lastNameLabel.Location = new Point(32, 139);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(88, 20);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameField
            // 
            firstNameField.Location = new Point(32, 104);
            firstNameField.Name = "firstNameField";
            firstNameField.Size = new Size(268, 23);
            firstNameField.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            firstNameLabel.ForeColor = Color.White;
            firstNameLabel.Location = new Point(32, 81);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(90, 20);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name:";
            // 
            // signupImg
            // 
            signupImg.Image = (Image)resources.GetObject("signupImg.Image");
            signupImg.Location = new Point(0, 0);
            signupImg.Name = "signupImg";
            signupImg.Size = new Size(381, 584);
            signupImg.SizeMode = PictureBoxSizeMode.StretchImage;
            signupImg.TabIndex = 1;
            signupImg.TabStop = false;
            // 
            // SignupPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 580);
            Controls.Add(signupImg);
            Controls.Add(panel1);
            Name = "SignupPanel";
            Text = "FitX";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signupImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label titleLabel;
        private Label firstNameLabel;
        private TextBox firstNameField;
        private Label lastNameLabel;
        private TextBox lastNameField;
        private TextBox emailField;
        private Label emailLabel;
        private Button registerBtn;
        private TextBox passwordField;
        private Label passwordLabel;
        private CheckBox showPassword;
        private PictureBox signupImg;
        private Button loginBtn;
        private TextBox confirmPasswordField;
        private Label confirmPasswordLabel;
    }
}
