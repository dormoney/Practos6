using Practos_6.Pages.Tickets;
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
using System.Windows.Shapes;

namespace Practos_6.Pages
{
    public partial class AddTicketWind : Window
    {

        private static AddTicketWind _instanse;

        public static AddTicketWind Instanse
        {
            get
            {
                if (_instanse == null)
                {
                    _instanse = new AddTicketWind();
                }
                return _instanse;
            }
        }

        public AddTicketWind()
        {
            InitializeComponent();
            _instanse = this;
            tickAdd.NavigationService.Navigate(new TickAddPage());
        }
    }
}
