namespace FitX
{
    partial class WorkoutPlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkoutPlans));
            HeaderPanel = new Panel();
            ExitBtn = new Button();
            ExercisesLabel = new Label();
            ExercisesHolder = new Panel();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            JumpingJacksHolder = new Panel();
            workoutPlan1_Content = new TextBox();
            JumpingJacksLabel = new Label();
            JumpingJacksImg = new PictureBox();
            HeaderPanel.SuspendLayout();
            ExercisesHolder.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            JumpingJacksHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JumpingJacksImg).BeginInit();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.Black;
            HeaderPanel.Controls.Add(ExitBtn);
            HeaderPanel.Controls.Add(ExercisesLabel);
            HeaderPanel.Location = new Point(-1, -1);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(943, 66);
            HeaderPanel.TabIndex = 1;
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
            // ExercisesLabel
            // 
            ExercisesLabel.AutoSize = true;
            ExercisesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExercisesLabel.ForeColor = Color.White;
            ExercisesLabel.Location = new Point(358, 10);
            ExercisesLabel.Name = "ExercisesLabel";
            ExercisesLabel.Size = new Size(214, 37);
            ExercisesLabel.TabIndex = 0;
            ExercisesLabel.Text = "HIIT EXERCISES";
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
            ExercisesHolder.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoScrollMargin = new Size(0, 30);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(454, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 329);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(42, 346);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 849);
            textBox1.TabIndex = 4;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 2;
            label1.Text = "Burpees";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(42, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(321, 298);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // JumpingJacksHolder
            // 
            JumpingJacksHolder.AutoScroll = true;
            JumpingJacksHolder.AutoScrollMargin = new Size(0, 30);
            JumpingJacksHolder.Controls.Add(workoutPlan1_Content);
            JumpingJacksHolder.Controls.Add(JumpingJacksLabel);
            JumpingJacksHolder.Controls.Add(JumpingJacksImg);
            JumpingJacksHolder.Location = new Point(18, 79);
            JumpingJacksHolder.Name = "JumpingJacksHolder";
            JumpingJacksHolder.Size = new Size(420, 329);
            JumpingJacksHolder.TabIndex = 0;
            // 
            // workoutPlan1_Content
            // 
            workoutPlan1_Content.BackColor = Color.Black;
            workoutPlan1_Content.BorderStyle = BorderStyle.None;
            workoutPlan1_Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            workoutPlan1_Content.ForeColor = Color.White;
            workoutPlan1_Content.Location = new Point(38, 356);
            workoutPlan1_Content.Multiline = true;
            workoutPlan1_Content.Name = "workoutPlan1_Content";
            workoutPlan1_Content.Size = new Size(322, 469);
            workoutPlan1_Content.TabIndex = 3;
            workoutPlan1_Content.Text = resources.GetString("workoutPlan1_Content.Text");
            // 
            // JumpingJacksLabel
            // 
            JumpingJacksLabel.AutoSize = true;
            JumpingJacksLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JumpingJacksLabel.ForeColor = Color.White;
            JumpingJacksLabel.Location = new Point(0, 13);
            JumpingJacksLabel.Name = "JumpingJacksLabel";
            JumpingJacksLabel.Size = new Size(141, 25);
            JumpingJacksLabel.TabIndex = 1;
            JumpingJacksLabel.Text = "Jumping Jacks";
            // 
            // JumpingJacksImg
            // 
            JumpingJacksImg.Image = (Image)resources.GetObject("JumpingJacksImg.Image");
            JumpingJacksImg.Location = new Point(38, 41);
            JumpingJacksImg.Name = "JumpingJacksImg";
            JumpingJacksImg.Size = new Size(322, 298);
            JumpingJacksImg.SizeMode = PictureBoxSizeMode.StretchImage;
            JumpingJacksImg.TabIndex = 0;
            JumpingJacksImg.TabStop = false;
            // 
            // WorkoutPlans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(941, 568);
            Controls.Add(ExercisesHolder);
            Controls.Add(HeaderPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WorkoutPlans";
            Text = "WorkoutPlans";
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ExercisesHolder.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            JumpingJacksHolder.ResumeLayout(false);
            JumpingJacksHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)JumpingJacksImg).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel HeaderPanel;
        private Label ExercisesLabel;
        private Panel ExercisesHolder;
        private Button ExitBtn;
        private PictureBox JumpingJacksImg;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel JumpingJacksHolder;
        private Label JumpingJacksLabel;
        private Label label1;
        private TextBox workoutPlan1_Content;
        private TextBox textBox1;
    }
}