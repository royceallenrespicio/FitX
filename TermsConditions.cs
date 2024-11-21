using System;

namespace FitX
{
    public partial class TermsConditions : Form
    {
        public bool IsConfirmed { get; private set; }

        public TermsConditions()
        {
            InitializeComponent();
            IsConfirmed = false;
        }

        private void confirmBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (confirmBtn.Checked == true)
            {
                IsConfirmed = true; 
                this.Close();
            }
            else
            {
                MessageBox.Show("You must agree to the Terms and Conditions to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
