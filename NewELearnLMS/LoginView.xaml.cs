using NewELearnLMS;
using System;
using System.Windows;
using System.Windows.Input;

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

 
            if (authService.AuthenticateUser(username, password))
            {

                MessageBox.Show("Login successful!");


                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
