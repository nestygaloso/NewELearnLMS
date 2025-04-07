using System;
using System.Windows;
using NewElearnLMS.View;

namespace NewELearnLMS
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //Display a MessageBox to let user choose which login to use
            MessageBoxResult result = MessageBox.Show(
                "Do you want to use the Secure Login? (Yes) \n\nClick No to use the Vulnerable Login.",
                "Choose Authentication Type",
                MessageBoxButton.YesNoCancel,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                //Launch Secure Login View
                var loginView = new LoginView();  //Your original LoginView
                loginView.Show();
            }
            else if (result == MessageBoxResult.No)
            {
                //Launch Vulnerable Login View
                var vulnerableLoginView = new VulnerableLoginView();  //Your new VulnerableLoginView
                vulnerableLoginView.Show();
            }
            else
            {
                //Exit application if user cancels
                Application.Current.Shutdown();
            }
        }
    }
}
