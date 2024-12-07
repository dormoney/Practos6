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
using Practos_6.Pages;
using System.ComponentModel;

namespace Practos_6.Pages.Tickets
{
    /// <summary>
    /// Логика взаимодействия для TickAddPage.xaml
    /// </summary>
    public partial class TickAddPage : Page
    {
        public TickAddPage()
        {
            InitializeComponent();
        }

        private void tickAdd_Click(object sender, RoutedEventArgs e)
        {
            string tick_type = txtNameTypeTick.Text;
            int tick_price = Convert.ToInt32(txtPriceTick.Text);
            var TickType = Myao.dbo.TicketTypes.FirstOrDefault(type => type.TypeName == tick_type);
            if (TickType != null)
            {
                MessageBox.Show("Такой тип уже существует!");
            }
            else
            {
                var tempTick = new TicketTypes()
                {
                    TypeName = tick_type,
                    Price = tick_price
                };
                Myao.dbo.TicketTypes.Add(tempTick);
                Myao.dbo.SaveChanges();
                Window wind = Window.GetWindow(this);
                wind.Close();
                MessageBox.Show("Тип билета был добавлен!");
            }
        }
    }
}
