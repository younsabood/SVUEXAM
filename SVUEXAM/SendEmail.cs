using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVUEXAM
{
    internal class SendEmail
    {
        public static async Task SendAsync(string recipientName, string recipientEmail)
        {
            try
            {
                using (var client = new SmtpClient("live.smtp.mailtrap.io", 587))
                {
                    client.Credentials = new NetworkCredential("api", "bb58e6126580d1bb5865116ac6ff1ed6");
                    client.EnableSsl = true;

                    // Generate a random verification code
                    string verificationCode = GenerateVerificationCode();
                    DateTime expirationTime = DateTime.Now.AddMinutes(2); // Code expires in 2 minutes
                    string dateTimeNow = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
                    string expirationTimeStr = expirationTime.ToString("yyyy/MM/dd HH:mm");

                    // Create a MailMessage object with HTML content
                    MailMessage mailMessage = new MailMessage
                    {
                        From = new MailAddress("mailtrap@demomailtrap.com"),
                        Subject = "Your Verification Code",
                        IsBodyHtml = true,
                        Body = $@"<!DOCTYPE html>
                                <html>
                                <head>
                                    <style>
                                        .header {{ color: #fff; background-color: #007BFF; padding: 10px; text-align: center; }}
                                        .content {{ font-family: Arial, sans-serif; padding: 20px; }}
                                        .code-box {{ font-size: 20px; font-weight: bold; color: #333; background-color: #f0f0f0; padding: 15px; border-radius: 5px; text-align: center; margin-top: 20px; }}
                                        .footer {{ color: #777; text-align: center; font-size: 12px; margin-top: 20px; }}
                                        .company-name {{ font-size: 24px; color: #333; margin-top: 10px; font-weight: bold; }}
                                        .developed-by {{ color: #555; margin-top: 10px; font-size: 12px; }}
                                    </style>
                                </head>
                                <body>
                                    <div class='header'>
                                        <h1>Email Verification For SVUEXAM APP</h1>
                                    </div>
                                    <div class='content'>
                                        <p>Hello {recipientName},</p>
                                        <p>Thank you for signing up! Please use the verification code below to complete your registration:</p>
                                        <p>Sent on: {dateTimeNow}</p>
                                        <div class='code-box'>{verificationCode}</div>
                                        <p>This code will expire on: {expirationTimeStr}</p>
                                        <p>If you did not request this code, please ignore this email.</p>
                                    </div>
                                    <div class='footer'>
                                        <p>&copy; 2024 SVUEXAM. All rights reserved.</p>
                                        <p class='developed-by'>Developed by ENG.YounsAbood</p>
                                    </div>
                                </body>
                                </html>"
                    };

                    // Add recipient(s)
                    mailMessage.To.Add(recipientEmail);

                    // Send the email asynchronously
                    await client.SendMailAsync(mailMessage);

                    // Notify user of success
                    MessageBox.Show(
                        "Verification email sent successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                // Notify user of failure
                MessageBox.Show(
                    $"An error occurred: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private static string GenerateVerificationCode()
        {
            Random random = new Random();
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";

            char[] code = new char[6];

            for (int i = 0; i < 6; i++)
            {
                code[i] = i < 3 ? letters[random.Next(letters.Length)] : numbers[random.Next(numbers.Length)];
            }
            return new string(code.OrderBy(c => random.Next()).ToArray());
        }

    }
}
