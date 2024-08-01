using System.Windows;

namespace NewElearnLMS
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Tab_Home_Click(object sender, RoutedEventArgs e)
        {
            // Code to handle Home tab click
            MessageBox.Show("Home tab clicked");
        }

        private void Tab_Course_Click(object sender, RoutedEventArgs e)
        {
            // Code to handle Course tab click
            MessageBox.Show("Course tab clicked");
        }

        private void Tab_Messages_Click(object sender, RoutedEventArgs e)
        {
            // Code to handle Messages tab click
            MessageBox.Show("Messages tab clicked");
        }

        private void Tab_Settings_Click(object sender, RoutedEventArgs e)
        {
            // Code to handle Settings tab click
            MessageBox.Show("Settings tab clicked");
        }

        private void StartCourseBtn_Click(object sender, RoutedEventArgs e)
        {
            // Code to start course
            MessageBox.Show("Start Course button clicked");
        }

        private void CustomerCareBtn_Click(object sender, RoutedEventArgs e)
        {
            // Code to handle Customer Care button click
            MessageBox.Show("Customer Care button clicked");
        }

        private void CourseSelectionComboBox_SelectionChanged_1(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Handle course selection change
            if (CourseSelectionComboBox.SelectedItem is System.Windows.Controls.ComboBoxItem selectedItem)
            {
                string selectedCourse = selectedItem.Tag.ToString();
                MessageBox.Show($"Selected course: {selectedCourse}");
            }
        }

        private void CustomerCareTxt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            // Code to handle text change in CustomerCareTxt
        }
    }
}
