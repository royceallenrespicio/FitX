namespace FitX
{
    partial class NewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPassword));
            headerPanel = new Panel();
            ExitBtn = new Button();
            headerLabel = new Label();
            code_Label = new Label();
            code_Field = new TextBox();
            newPassword_Label = new Label();
            newPassword_Field = new TextBox();
            newPasswordBtn = new Button();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(17, 17, 17);
            headerPanel.Controls.Add(ExitBtn);
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Location = new Point(-3, -3);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(583, 61);
            headerPanel.TabIndex = 1;
            // 
            // ExitBtn
            // 
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Image = (Image)resources.GetObject("ExitBtn.Image");
            ExitBtn.Location = new Point(532, 15);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(37, 37);
            ExitBtn.TabIndex = 2;
            ExitBtn.UseVisualStyleBackColor = true;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(213, 21);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(148, 25);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "New Password";
            // 
            // code_Label
            // 
            code_Label.AutoSize = true;
            code_Label.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            code_Label.ForeColor = Color.White;
            code_Label.Location = new Point(144, 113);
            code_Label.Name = "code_Label";
            code_Label.Size = new Size(89, 20);
            code_Label.TabIndex = 2;
            code_Label.Text = "Enter Code:";
            // 
            // code_Field
            // 
            code_Field.BorderStyle = BorderStyle.None;
            code_Field.Location = new Point(254, 117);
            code_Field.Name = "code_Field";
            code_Field.Size = new Size(212, 16);
            code_Field.TabIndex = 3;
            // 
            // newPassword_Label
            // 
            newPassword_Label.AutoSize = true;
            newPassword_Label.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newPassword_Label.ForeColor = Color.White;
            newPassword_Label.Location = new Point(76, 149);
            newPassword_Label.Name = "newPassword_Label";
            newPassword_Label.Size = new Size(157, 20);
            newPassword_Label.TabIndex = 4;
            newPassword_Label.Text = "Enter New Password:";
            // 
            // newPassword_Field
            // 
            newPassword_Field.BorderStyle = BorderStyle.None;
            newPassword_Field.Location = new Point(254, 153);
            newPassword_Field.Name = "newPassword_Field";
            newPassword_Field.Size = new Size(212, 16);
            newPassword_Field.TabIndex = 5;
            // 
            // newPasswordBtn
            // 
            newPasswordBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newPasswordBtn.Location = new Point(210, 237);
            newPasswordBtn.Name = "newPasswordBtn";
            newPasswordBtn.Size = new Size(143, 28);
            newPasswordBtn.TabIndex = 6;
            newPasswordBtn.Text = "Confirm";
            newPasswordBtn.UseVisualStyleBackColor = true;
            newPasswordBtn.Click += newPasswordBtn_Click;
            // 
            // NewPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(578, 277);
            Controls.Add(newPasswordBtn);
            Controls.Add(newPassword_Field);
            Controls.Add(newPassword_Label);
            Controls.Add(code_Field);
            Controls.Add(code_Label);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewPassword";
            Text = "NewPassword";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerPanel;
        private Button ExitBtn;
        private Label headerLabel;
        private Label code_Label;
        private TextBox code_Field;
        private Label newPassword_Label;
        private TextBox newPassword_Field;
        private Button newPasswordBtn;
    }
}