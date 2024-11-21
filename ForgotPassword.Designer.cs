namespace FitX
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            panel1 = new Panel();
            ExitBtn = new Button();
            headerLabel = new Label();
            email_Label = new Label();
            email_Field = new TextBox();
            newPasswordBtn = new Button();
            newPasswordLabel = new Label();
            password_Field = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 17, 17);
            panel1.Controls.Add(ExitBtn);
            panel1.Controls.Add(headerLabel);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(501, 57);
            panel1.TabIndex = 0;
            // 
            // ExitBtn
            // 
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Image = (Image)resources.GetObject("ExitBtn.Image");
            ExitBtn.Location = new Point(450, 12);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(37, 37);
            ExitBtn.TabIndex = 2;
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(160, 15);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(168, 25);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Forgot Password";
            // 
            // email_Label
            // 
            email_Label.AutoSize = true;
            email_Label.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email_Label.ForeColor = Color.White;
            email_Label.Location = new Point(118, 122);
            email_Label.Name = "email_Label";
            email_Label.Size = new Size(51, 20);
            email_Label.TabIndex = 1;
            email_Label.Text = "Email:";
            // 
            // email_Field
            // 
            email_Field.BorderStyle = BorderStyle.None;
            email_Field.Location = new Point(175, 126);
            email_Field.Name = "email_Field";
            email_Field.Size = new Size(212, 16);
            email_Field.TabIndex = 2;
            email_Field.TextChanged += email_Field_TextChanged;
            // 
            // newPasswordBtn
            // 
            newPasswordBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newPasswordBtn.Location = new Point(168, 258);
            newPasswordBtn.Name = "newPasswordBtn";
            newPasswordBtn.Size = new Size(143, 28);
            newPasswordBtn.TabIndex = 3;
            newPasswordBtn.Text = "Send New Password";
            newPasswordBtn.UseVisualStyleBackColor = true;
            newPasswordBtn.Click += newPasswordBtn_Click;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newPasswordLabel.ForeColor = Color.White;
            newPasswordLabel.Location = new Point(89, 167);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(80, 20);
            newPasswordLabel.TabIndex = 4;
            newPasswordLabel.Text = "Password:";
            // 
            // password_Field
            // 
            password_Field.BorderStyle = BorderStyle.None;
            password_Field.Location = new Point(175, 171);
            password_Field.Name = "password_Field";
            password_Field.Size = new Size(212, 16);
            password_Field.TabIndex = 5;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(498, 317);
            Controls.Add(password_Field);
            Controls.Add(newPasswordLabel);
            Controls.Add(newPasswordBtn);
            Controls.Add(email_Field);
            Controls.Add(email_Label);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label headerLabel;
        private Label email_Label;
        private TextBox email_Field;
        private Button newPasswordBtn;
        private Button ExitBtn;
        private Label newPasswordLabel;
        private TextBox password_Field;
    }
}