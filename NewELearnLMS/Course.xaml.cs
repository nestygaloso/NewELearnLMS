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
            //minimizing the window
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //closing the window
            this.Close();
        }

        private void Course_btnpdf1_Click(object sender, RoutedEventArgs e)
        {
            //to code to handle the PDF button click
            MessageBox.Show("PDF 1 Button Clicked");
        }

        private void Tab_Home_Click(object sender, RoutedEventArgs e)
        {
            //section for the Tab_Home button click
            MessageBox.Show("Home Tab Clicked");
        }

        private void Tab_Messages_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Messages Tab Clicked");
        }

        private void CustomerCareBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Customer Care Button Clicked");
        }

        private void CustomerCareTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                MessageBox.Show($"Customer Care TextBox Text Changed: {textBox.Text}");
            }
        }

        private void Course_btn2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Course_btn1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
