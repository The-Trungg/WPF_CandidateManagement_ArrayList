using CandidateManagement_DAL.Entities;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArrayList_CandidateManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Hraccount NowAccount = new Hraccount();
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Hraccount account)
        {
            InitializeComponent();
            this.NowAccount = account;
            WelcomeLabel.Content = $"Welcome, {account.FullName}";
        }

        private void Candidate_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfileWindow candidateProfileWindow = new CandidateProfileWindow(NowAccount);
            candidateProfileWindow.Show();
            this.Close();
        }

        private void btn_hrAccount_Click(object sender, RoutedEventArgs e)
        {
            HRAccountWindow hRAccountWindow = new HRAccountWindow(NowAccount);
            hRAccountWindow.Show();
            this.Close();
        }

        private void Job_Click(object sender, RoutedEventArgs e)
        {
            JobPostingWindow job = new JobPostingWindow(NowAccount);
            job.Show();
            this.Close();
        }

        private void Logoutbtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result =
MessageBox.Show("Are you sure to logout?", "Logout", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                this.Close();
                LoginWindow log = new LoginWindow();
                log.Show();
            }
            else
            {
                return;
            }
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result =
MessageBox.Show("Are you sure to quit?", "Quit", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
            {
                return;
            }
        }
    }
}