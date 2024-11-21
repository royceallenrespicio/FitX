namespace FitX
{
    partial class MealPlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealPlans));
            MealsLabel = new Label();
            HeaderPanel = new Panel();
            ExitBtn = new Button();
            mealPlan1_Label = new Label();
            label1 = new Label();
            JumpingJacksImg = new PictureBox();
            pictureBox2 = new PictureBox();
            ExercisesHolder = new Panel();
            panel1 = new Panel();
            mealPlan2Content = new TextBox();
            JumpingJacksHolder = new Panel();
            mealPlan1_Content = new TextBox();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JumpingJacksImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ExercisesHolder.SuspendLayout();
            panel1.SuspendLayout();
            JumpingJacksHolder.SuspendLayout();
            SuspendLayout();
            // 
            // MealsLabel
            // 
            MealsLabel.AutoSize = true;
            MealsLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MealsLabel.ForeColor = Color.White;
            MealsLabel.Location = new Point(379, 10);
            MealsLabel.Name = "MealsLabel";
            MealsLabel.Size = new Size(184, 37);
            MealsLabel.TabIndex = 0;
            MealsLabel.Text = "MEAL PLANS";
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.Black;
            HeaderPanel.Controls.Add(ExitBtn);
            HeaderPanel.Controls.Add(MealsLabel);
            HeaderPanel.Location = new Point(-1, -1);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(942, 65);
            HeaderPanel.TabIndex = 3;
            // 
            // ExitBtn
            // 
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Image = (Image)resources.GetObject("ExitBtn.Image");
            ExitBtn.Location = new Point(893, 10);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(37, 37);
            ExitBtn.TabIndex = 1;
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // mealPlan1_Label
            // 
            mealPlan1_Label.AutoSize = true;
            mealPlan1_Label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mealPlan1_Label.ForeColor = Color.White;
            mealPlan1_Label.Location = new Point(0, 0);
            mealPlan1_Label.Name = "mealPlan1_Label";
            mealPlan1_Label.Size = new Size(223, 25);
            mealPlan1_Label.TabIndex = 1;
            mealPlan1_Label.Text = "Avocado Toast with Egg";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 2;
            label1.Text = "Overnight Oats";
            // 
            // JumpingJacksImg
            // 
            JumpingJacksImg.Image = (Image)resources.GetObject("JumpingJacksImg.Image");
            JumpingJacksImg.Location = new Point(37, 28);
            JumpingJacksImg.Name = "JumpingJacksImg";
            JumpingJacksImg.Size = new Size(322, 298);
            JumpingJacksImg.SizeMode = PictureBoxSizeMode.StretchImage;
            JumpingJacksImg.TabIndex = 0;
            JumpingJacksImg.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(38, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(321, 298);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // ExercisesHolder
            // 
            ExercisesHolder.AutoScroll = true;
            ExercisesHolder.AutoScrollMargin = new Size(0, 20);
            ExercisesHolder.BackColor = Color.Black;
            ExercisesHolder.BorderStyle = BorderStyle.FixedSingle;
            ExercisesHolder.Controls.Add(panel1);
            ExercisesHolder.Controls.Add(JumpingJacksHolder);
            ExercisesHolder.Location = new Point(12, 78);
            ExercisesHolder.Name = "ExercisesHolder";
            ExercisesHolder.Size = new Size(917, 478);
            ExercisesHolder.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoScrollMargin = new Size(0, 30);
            panel1.Controls.Add(mealPlan2Content);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(456, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 329);
            panel1.TabIndex = 1;
            // 
            // mealPlan2Content
            // 
            mealPlan2Content.BackColor = Color.Black;
            mealPlan2Content.BorderStyle = BorderStyle.None;
            mealPlan2Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mealPlan2Content.ForeColor = Color.White;
            mealPlan2Content.Location = new Point(38, 350);
            mealPlan2Content.Multiline = true;
            mealPlan2Content.Name = "mealPlan2Content";
            mealPlan2Content.Size = new Size(322, 392);
            mealPlan2Content.TabIndex = 3;
            mealPlan2Content.Text = resources.GetString("mealPlan2Content.Text");
            // 
            // JumpingJacksHolder
            // 
            JumpingJacksHolder.AutoScroll = true;
            JumpingJacksHolder.AutoScrollMargin = new Size(0, 30);
            JumpingJacksHolder.Controls.Add(mealPlan1_Content);
            JumpingJacksHolder.Controls.Add(mealPlan1_Label);
            JumpingJacksHolder.Controls.Add(JumpingJacksImg);
            JumpingJacksHolder.Location = new Point(16, 67);
            JumpingJacksHolder.Name = "JumpingJacksHolder";
            JumpingJacksHolder.Size = new Size(420, 329);
            JumpingJacksHolder.TabIndex = 0;
            // 
            // mealPlan1_Content
            // 
            mealPlan1_Content.BackColor = Color.Black;
            mealPlan1_Content.BorderStyle = BorderStyle.None;
            mealPlan1_Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mealPlan1_Content.ForeColor = Color.White;
            mealPlan1_Content.Location = new Point(37, 345);
            mealPlan1_Content.Multiline = true;
            mealPlan1_Content.Name = "mealPlan1_Content";
            mealPlan1_Content.Size = new Size(322, 392);
            mealPlan1_Content.TabIndex = 2;
            mealPlan1_Content.Text = resources.GetString("mealPlan1_Content.Text");
            // 
            // MealPlans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(941, 568);
            Controls.Add(HeaderPanel);
            Controls.Add(ExercisesHolder);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MealPlans";
            Text = "Meals";
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)JumpingJacksImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ExercisesHolder.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            JumpingJacksHolder.ResumeLayout(false);
            JumpingJacksHolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label MealsLabel;
        private Panel HeaderPanel;
        private Button ExitBtn;
        private Label mealPlan1_Label;
        private Label label1;
        private PictureBox JumpingJacksImg;
        private PictureBox pictureBox2;
        private Panel ExercisesHolder;
        private Panel panel1;
        private Panel JumpingJacksHolder;
        private TextBox mealPlan1_Content;
        private TextBox mealPlan2Content;
    }
}