using NewELearnLMS;
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
            //code to handle Home tab click
            MessageBox.Show("Home tab clicked");
        }

        private void Tab_Course_Click(object sender, RoutedEventArgs e)
        {
            //section to handle Course tab click
            Course Course1 = new Course();
            Course1.Show();
            this.Close();
            MessageBox.Show("Course tab clicked");
        }

        private void Tab_Messages_Click(object sender, RoutedEventArgs e)
        {
            //section to handle Messages tab click
            Messages Messages1 = new Messages();
            Messages1.Show();
            this.Close();
            MessageBox.Show("Messages tab clicked");
        }

        private void Tab_Settings_Click(object sender, RoutedEventArgs e)
        {
            //section to handle Settings tab click
            MessageBox.Show("Settings tab clicked");
        }

        private void StartCourseBtn_Click(object sender, RoutedEventArgs e)
        {
            //part to start course
            MessageBox.Show("Start Course button clicked");
        }

        private void CustomerCareBtn_Click(object sender, RoutedEventArgs e)
        {
            //code to handle Customer Care button click
            MessageBox.Show("Customer Care button clicked");
        }

        private void CourseSelectionComboBox_SelectionChanged_1(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //to handle course selection change
            if (CourseSelectionComboBox.SelectedItem is System.Windows.Controls.ComboBoxItem selectedItem)
            {
                string selectedCourse = selectedItem.Tag.ToString();
                MessageBox.Show($"Selected course: {selectedCourse}");
            }
        }

        private void CustomerCareTxt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
          
        }
    }
}
