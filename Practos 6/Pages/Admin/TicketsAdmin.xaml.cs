using Practos_6.youyou;
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

namespace Practos_6.Pages
{
    /// <summary>
    /// Логика взаимодействия для TicketsAdmin.xaml
    /// </summary>
    public partial class TicketsAdmin : Page
    {
        public TicketsAdmin()
        {
            InitializeComponent();
            TypesList.ItemsSource = Myao.dbo.TicketTypes.ToList();
        }


        private void tickAdd_Click(object sender, RoutedEventArgs e)
        {
            AddTicketWind addTicketWind = new AddTicketWind();
            addTicketWind.Show();
        }

        private void TypesList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (TypesList.SelectedItem != null)
            {
                TicketTypes tickDel = TypesList.SelectedItem as TicketTypes;
                var isValiable = Myao.dbo.Tickets.FirstOrDefault(tick => tick.TicketTypeID == tickDel.TicketTypeID);
                if (isValiable != null)
                {
                    MessageBox.Show("Этот тип билета используется");
                } else
                {
                    Myao.dbo.TicketTypes.Remove(tickDel);
                    Myao.dbo.SaveChanges();
                    TypesList.ItemsSource = Myao.dbo.TicketTypes.ToList();
                    MessageBox.Show("Тип билета был удален");
                }
            }
        }

        private void Upd_Click(object sender, RoutedEventArgs e)
        {
            TypesList.ItemsSource = Myao.dbo.TicketTypes.ToList();
        }
    }
}
