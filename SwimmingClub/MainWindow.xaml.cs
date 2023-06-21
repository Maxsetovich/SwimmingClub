using SwimmingClub.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SwimmingClub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else this.WindowState = WindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void brDragable_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void rbDashboard_Click(object sender, RoutedEventArgs e)
        {
            DashboardPage dashboardPage = new DashboardPage();
            PageNavigator.Content = dashboardPage;
        }

        private void rbPackages_Click(object sender, RoutedEventArgs e)
        {
            PackagesPage packagesPage = new PackagesPage();
            PageNavigator.Content = packagesPage;
        }

        private void rbMembers_Click(object sender, RoutedEventArgs e)
        {
            MembersPage membersPage = new MembersPage();
            PageNavigator.Content = membersPage;
        }

        private void rbInstructors_Click(object sender, RoutedEventArgs e)
        {
            InstructorsPage instructorsPage = new InstructorsPage();
            PageNavigator.Content = instructorsPage;
        }

        private void rbClients_Click(object sender, RoutedEventArgs e)
        {
            ClientsPage clientsPage = new ClientsPage();
            PageNavigator.Content = clientsPage;
        }

        private void rbPayments_Click(object sender, RoutedEventArgs e)
        {
            PaymentsPage paymentsPage = new PaymentsPage();
            PageNavigator.Content = paymentsPage;
        }

        private void rbFAQ_Click(object sender, RoutedEventArgs e)
        {
            FAQPage faqPage = new FAQPage();
            PageNavigator.Content = faqPage;
        }

        private void rbAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutPage aboutPage = new AboutPage();
            PageNavigator.Content = aboutPage;
        }
    }
}
