using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NewElearnLMS.View
{
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Allow the window to be dragged
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            // Minimize the window
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            // Close the window
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Perform login logic
            string username = txtUser.Text;
            string password = txtPass.Password;

            // Example authentication logic (replace with real authentication)
            if (AuthenticateUser(username, password))
            {
                // Logic to proceed to the next view
                MessageBox.Show("Login successful!");

                // Open the main application window and close the login window
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Replace with actual authentication logic
            // For demonstration, accept any non-empty username and password
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
        }
    }
}
