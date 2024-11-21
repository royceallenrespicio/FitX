using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitX
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPanel loginPanel = new LoginPanel();
            loginPanel.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {

        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {

        }

        private void contactBtn_Click(object sender, EventArgs e)
        {

        }

        private void workoutplansBtn_Click(object sender, EventArgs e)
        {
            WorkoutPlans workoutPlans = new WorkoutPlans();
            workoutPlans.Show();
        }

        private void mealPlansBtn_Click(object sender, EventArgs e)
        {
            MealPlans mealPlans = new MealPlans();
            mealPlans.Show();
        }
    }
}
