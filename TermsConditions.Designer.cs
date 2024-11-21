namespace FitX
{
    partial class TermsConditions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermsConditions));
            davidGoggins = new PictureBox();
            label1 = new Label();
            termsAndConditionsField = new TextBox();
            confirmBtn = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)davidGoggins).BeginInit();
            SuspendLayout();
            // 
            // davidGoggins
            // 
            davidGoggins.Image = (Image)resources.GetObject("davidGoggins.Image");
            davidGoggins.Location = new Point(-5, -2);
            davidGoggins.Name = "davidGoggins";
            davidGoggins.Size = new Size(310, 527);
            davidGoggins.SizeMode = PictureBoxSizeMode.StretchImage;
            davidGoggins.TabIndex = 0;
            davidGoggins.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(384, 26);
            label1.Name = "label1";
            label1.Size = new Size(399, 50);
            label1.TabIndex = 3;
            label1.Text = "Terms and Conditions";
            // 
            // termsAndConditionsField
            // 
            termsAndConditionsField.BackColor = Color.Black;
            termsAndConditionsField.BorderStyle = BorderStyle.None;
            termsAndConditionsField.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            termsAndConditionsField.ForeColor = Color.White;
            termsAndConditionsField.Location = new Point(356, 93);
            termsAndConditionsField.Multiline = true;
            termsAndConditionsField.Name = "termsAndConditionsField";
            termsAndConditionsField.ScrollBars = ScrollBars.Vertical;
            termsAndConditionsField.Size = new Size(443, 361);
            termsAndConditionsField.TabIndex = 4;
            termsAndConditionsField.Text = resources.GetString("termsAndConditionsField.Text");
            // 
            // confirmBtn
            // 
            confirmBtn.AutoSize = true;
            confirmBtn.FlatAppearance.BorderSize = 0;
            confirmBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmBtn.ForeColor = Color.White;
            confirmBtn.Location = new Point(421, 477);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(289, 21);
            confirmBtn.TabIndex = 5;
            confirmBtn.Text = "I agree with the Terms and Conditions of FitX";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.CheckedChanged += confirmBtn_CheckedChanged;
            // 
            // TermsConditions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(858, 524);
            Controls.Add(confirmBtn);
            Controls.Add(termsAndConditionsField);
            Controls.Add(label1);
            Controls.Add(davidGoggins);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TermsConditions";
            Text = "TermsConditions";
            ((System.ComponentModel.ISupportInitialize)davidGoggins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox davidGoggins;
        private Label label1;
        private TextBox termsAndConditionsField;
        private CheckBox confirmBtn;
    }
}