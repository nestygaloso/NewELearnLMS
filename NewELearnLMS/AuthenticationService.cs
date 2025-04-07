using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace NewELearnLMS
{
    public class AuthenticationService
    {
        private readonly Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "user1", HashPassword("password1") },
            { "admin", HashPassword("adminpw1") },
            { "user2", HashPassword("password2") }
        };

        private readonly Dictionary<string, string> userEmails = new Dictionary<string, string>
        {
            { "user1", "user1_email@example.com" },
            { "admin", "nesty.galoso89@gmail.com" },
            { "user2", "user2_email@example.com" }
        };

        private string lastGeneratedOTP;

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                StringBuilder builder = new StringBuilder();
                foreach (var b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool AuthenticateUser(string username, string password)
        {
            if (users.ContainsKey(username))
            {
                string hashedPassword = HashPassword(password);

                if (users[username] == hashedPassword)
                {
                    //If password is correct, proceed to OTP generation
                    string otp = GenerateOTP();
                    bool otpSent = SendOTPByEmail(userEmails[username], otp);

                    if (otpSent)
                    {
                        lastGeneratedOTP = otp;  //Store the OTP for validation
                        return true;  //Authentication successful (Password verified, OTP sent)
                    }
                    else
                    {
                        MessageBox.Show("Failed to send OTP. Please check your email configuration.", "Email Error");
                    }
                }
            }
            return false;  //Authentication failed
        }

        public bool VerifyOTP(string inputOtp)
        {
            //Check if the entered OTP matches the generated one
            return inputOtp == lastGeneratedOTP;
        }

        private string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();  //Generate a 6-digit random OTP
        }

        private bool SendOTPByEmail(string email, string otp)
        {
            try
            {
                using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
                {
                    client.Port = 587;
                    client.Credentials = new NetworkCredential("nesty.galoso89@gmail.com", "yxmmsqilytqalbyh"); 
                    client.EnableSsl = true;

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("nesty.galoso89@gmail.com");
                    mail.To.Add(email);
                    mail.Subject = "NewELearnLMS - Your OTP Code";
                    mail.Body = $"Your OTP Code is: {otp}. It is valid for 5 minutes.";

                    client.Send(mail);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending OTP: {ex.Message}", "Email Error");
                return false;
            }
        }
    }
}
