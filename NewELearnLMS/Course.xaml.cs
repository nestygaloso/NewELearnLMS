using System.Windows;
using System.Windows.Controls;

namespace NewELearnLMS
{
    public partial class Course : Window
    {
        public Course()
        {
            InitializeComponent();
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

        private void Course_btnpdf1_Click(object sender, RoutedEventArgs e)
        {
            // Code to handle the PDF button click
            MessageBox.Show("PDF 1 Button Clicked");
        }

        private void Tab_Home_Click(object sender, RoutedEventArgs e)
        {
            // Handle the Tab_Home button click
            MessageBox.Show("Home Tab Clicked");
        }

        private void Tab_Messages_Click(object sender, RoutedEventArgs e)
        {
            // Handle the Tab_Messages button click
            MessageBox.Show("Messages Tab Clicked");
        }

        private void CustomerCareBtn_Click(object sender, RoutedEventArgs e)
        {
            // Handle the CustomerCareBtn button click
            MessageBox.Show("Customer Care Button Clicked");
        }

        private void CustomerCareTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Handle text change in CustomerCareTxt TextBox
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                // Example action: Update based on text change
                MessageBox.Show($"Customer Care TextBox Text Changed: {textBox.Text}");
            }
        }
    }
}
