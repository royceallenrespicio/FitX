namespace FitX
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            workoutPlans = new GroupBox();
            workoutplansBtn = new PictureBox();
            mealPlans = new GroupBox();
            mealPlansBtn = new PictureBox();
            logoLabel = new Label();
            homeBtn = new Button();
            aboutBtn = new Button();
            contactBtn = new Button();
            bannerBox = new PictureBox();
            logoutBtn = new Button();
            quoteLabel = new Label();
            workoutPlans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)workoutplansBtn).BeginInit();
            mealPlans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mealPlansBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bannerBox).BeginInit();
            SuspendLayout();
            // 
            // workoutPlans
            // 
            workoutPlans.Controls.Add(workoutplansBtn);
            workoutPlans.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            workoutPlans.ForeColor = Color.White;
            workoutPlans.Location = new Point(128, 352);
            workoutPlans.Name = "workoutPlans";
            workoutPlans.Size = new Size(268, 253);
            workoutPlans.TabIndex = 0;
            workoutPlans.TabStop = false;
            workoutPlans.Text = "WORKOUT PLANS";
            // 
            // workoutplansBtn
            // 
            workoutplansBtn.Image = (Image)resources.GetObject("workoutplansBtn.Image");
            workoutplansBtn.Location = new Point(6, 19);
            workoutplansBtn.Name = "workoutplansBtn";
            workoutplansBtn.Size = new Size(256, 228);
            workoutplansBtn.SizeMode = PictureBoxSizeMode.Zoom;
            workoutplansBtn.TabIndex = 0;
            workoutplansBtn.TabStop = false;
            workoutplansBtn.Click += workoutplansBtn_Click;
            // 
            // mealPlans
            // 
            mealPlans.Controls.Add(mealPlansBtn);
            mealPlans.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mealPlans.ForeColor = Color.White;
            mealPlans.Location = new Point(514, 352);
            mealPlans.Name = "mealPlans";
            mealPlans.Size = new Size(270, 253);
            mealPlans.TabIndex = 1;
            mealPlans.TabStop = false;
            mealPlans.Text = "MEAL PLANS";
            // 
            // mealPlansBtn
            // 
            mealPlansBtn.Image = (Image)resources.GetObject("mealPlansBtn.Image");
            mealPlansBtn.Location = new Point(6, 19);
            mealPlansBtn.Name = "mealPlansBtn";
            mealPlansBtn.Size = new Size(258, 228);
            mealPlansBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            mealPlansBtn.TabIndex = 0;
            mealPlansBtn.TabStop = false;
            mealPlansBtn.Click += mealPlansBtn_Click;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoLabel.ForeColor = Color.White;
            logoLabel.Location = new Point(38, 37);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(127, 65);
            logoLabel.TabIndex = 5;
            logoLabel.Text = "FITX";
            // 
            // homeBtn
            // 
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeBtn.ForeColor = Color.White;
            homeBtn.Location = new Point(513, 52);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(83, 41);
            homeBtn.TabIndex = 6;
            homeBtn.Text = "HOME";
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // aboutBtn
            // 
            aboutBtn.FlatAppearance.BorderSize = 0;
            aboutBtn.FlatStyle = FlatStyle.Flat;
            aboutBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aboutBtn.ForeColor = Color.White;
            aboutBtn.Location = new Point(628, 52);
            aboutBtn.Name = "aboutBtn";
            aboutBtn.Size = new Size(84, 41);
            aboutBtn.TabIndex = 7;
            aboutBtn.Text = "ABOUT";
            aboutBtn.UseVisualStyleBackColor = true;
            aboutBtn.Click += aboutBtn_Click;
            // 
            // contactBtn
            // 
            contactBtn.FlatAppearance.BorderSize = 0;
            contactBtn.FlatStyle = FlatStyle.Flat;
            contactBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactBtn.ForeColor = Color.White;
            contactBtn.Location = new Point(744, 52);
            contactBtn.Name = "contactBtn";
            contactBtn.Size = new Size(107, 41);
            contactBtn.TabIndex = 8;
            contactBtn.Text = "CONTACT";
            contactBtn.UseVisualStyleBackColor = true;
            contactBtn.Click += contactBtn_Click;
            // 
            // bannerBox
            // 
            bannerBox.Image = (Image)resources.GetObject("bannerBox.Image");
            bannerBox.Location = new Point(51, 130);
            bannerBox.Name = "bannerBox";
            bannerBox.Size = new Size(820, 198);
            bannerBox.SizeMode = PictureBoxSizeMode.StretchImage;
            bannerBox.TabIndex = 9;
            bannerBox.TabStop = false;
            // 
            // logoutBtn
            // 
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(64, 23);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(65, 29);
            logoutBtn.TabIndex = 10;
            logoutBtn.Text = "LOG OUT";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // quoteLabel
            // 
            quoteLabel.AutoSize = true;
            quoteLabel.BackColor = Color.Transparent;
            quoteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quoteLabel.ForeColor = Color.White;
            quoteLabel.Location = new Point(286, 144);
            quoteLabel.Name = "quoteLabel";
            quoteLabel.Size = new Size(333, 21);
            quoteLabel.TabIndex = 11;
            quoteLabel.Text = "\"Who's gon carry the boats, and the logs?\"";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(939, 631);
            Controls.Add(quoteLabel);
            Controls.Add(logoutBtn);
            Controls.Add(bannerBox);
            Controls.Add(contactBtn);
            Controls.Add(aboutBtn);
            Controls.Add(homeBtn);
            Controls.Add(logoLabel);
            Controls.Add(mealPlans);
            Controls.Add(workoutPlans);
            Name = "Dashboard";
            Text = "Dashboard";
            workoutPlans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)workoutplansBtn).EndInit();
            mealPlans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mealPlansBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)bannerBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox workoutPlans;
        private GroupBox mealPlans;
        private PictureBox workoutplansBtn;
        private PictureBox mealPlansBtn;
        private Label logoLabel;
        private Button homeBtn;
        private Button aboutBtn;
        private Button contactBtn;
        private PictureBox bannerBox;
        private Button logoutBtn;
        private Label quoteLabel;
    }
}