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

        // Event handler for the Minimize button
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            // Minimize the window
            WindowState = WindowState.Minimized;
        }

        // Event handler for the Close button
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            // Close the window
            Close();
        }

        // Event handler for the Send button
        private void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle sending the message
            // For example, you could collect the message text and process it here
            string message = MessageInput.Text;
            if (!string.IsNullOrEmpty(message))
            {
                // Add your message processing logic here
                MessageBox.Show("Message sent: " + message);
                MessageInput.Clear(); // Clear the message input after sending
            }
            else
            {
                MessageBox.Show("Please enter a message before sending.");
            }
        }

        // Event handler for the Home tab button
        private void Tab_Home_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the Home view or perform any action related to the Home tab
            // For example:
            // var homeView = new HomeView();
            // homeView.Show();
            // this.Close();
        }

        // Event handler for the Messages tab button
        private void Tab_Messages_Click(object sender, RoutedEventArgs e)
        {
            // Handle clicking the Messages tab if necessary
            // You might want to do nothing here if it's already on the Messages view
        }

        // Event handler for the Customer Care button
        private void CustomerCareBtn_Click(object sender, RoutedEventArgs e)
        {
            // Handle Customer Care button click
            // For example, you might want to open a new window or show additional help
            MessageBox.Show("Customer Care clicked.");
        }

        // Event handler for Customer Care TextBox text change
        private void CustomerCareTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Handle text changes in the Customer Care TextBox if needed
        }
    }
}
