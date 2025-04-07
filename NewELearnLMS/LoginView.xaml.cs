using NewELearnLMS;
using System;
using System.Windows;
using System.Windows.Input;
using Microsoft.VisualBasic;

namespace NewElearnLMS.View
{
    public partial class LoginView : Window
    {
        private AuthenticationService authService;

        public LoginView()
        {
            InitializeComponent();
            authService = new AuthenticationService();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Password;

            //Test Code - Displaying Hashed Password
            string hashedPassword = AuthenticationService.HashPassword(password);
            MessageBox.Show($"Hashed Password: {hashedPassword}", "Debug Info");

            //Checking if the user is authenticated
            if (authService.AuthenticateUser(username, password))
            {
                MessageBox.Show("Password Verified! An OTP has been sent to your email.");

                //Prompt user to enter the OTP
                string userInputOtp = Interaction.InputBox("Enter the OTP sent to your email:", "OTP Verification");

                if (authService.VerifyOTP(userInputOtp))
                {
                    MessageBox.Show("Login successful!");

                    //Proceed to Main Window
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid OTP. Login failed.");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
