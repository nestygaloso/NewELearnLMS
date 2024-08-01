using System.Windows;
using System.Windows.Controls;

namespace NewELearnLMS
{
    public partial class Messages : Window
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            string message = MessageInput.Text;
            if (!string.IsNullOrEmpty(message))
            {
                //to add your message processing logic here
                MessageBox.Show("Message sent: " + message);
                MessageInput.Clear(); //to clear the message input after sending
            }
            else
            {
                MessageBox.Show("Please enter a message before sending.");
            }
        }

        private void Tab_Home_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tab_Messages_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CustomerCareBtn_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Customer Care clicked.");
        }

        private void CustomerCareTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
