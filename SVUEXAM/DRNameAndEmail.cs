using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVUEXAM
{
    public partial class DRNameAndEmail : UserControl
    {
        public DRNameAndEmail()
        {
            InitializeComponent();
        }

        private async void PersonalEmail_IconRightClick(object sender, EventArgs e)
        {
            try
            {
                string recipientName = ENName.Text; // Fetch from form field
                string recipientEmail = PersonalEmail.Text; // Fetch from form field

                // Call the asynchronous method to send email
                await SendEmail.SendAsync(recipientName, recipientEmail);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during email sending
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificationCode_TextChanged(object sender, EventArgs e)
        {
            if (VerificationCode.Text == SendEmail.verificationCode)
            {
                VerificationCode.IconRight = Properties.Resources.correctIcon;
            }
            else
            {
                VerificationCode.IconRight = null;
            }
        }
    }
}
