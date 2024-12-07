using Practos_6.Pages;
using Practos_6.Pages.Admin;
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

namespace Practos_6.NavBars
{
    /// <summary>
    /// Логика взаимодействия для AdminNav.xaml
    /// </summary>
    public partial class AdminNav : Page
    {
        public AdminNav()
        {
            InitializeComponent();
        }

        private void ExitBut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instanse.navBar.Navigate(null);
            MainWindow.Instanse.mainFrame.Navigate(new LoginPage());
        }

        private void TickBut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instanse.mainFrame.Navigate(new TicketsAdmin());
        }

        private void Audience_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instanse.mainFrame.Navigate(new AudAdmin());
        }
    }
}
