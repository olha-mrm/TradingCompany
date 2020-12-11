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
using DTO;
using BusinessLogic.Interfaces;

namespace CompanyWPF
{
    /// <summary>
    /// Interaction logic for Statuses.xaml
    /// </summary>
    public partial class Statuses : Window
    {
        private IOrdersManager _ordersManager;
        private UserDTO _user;
        long _id;
        public Statuses(IOrdersManager orderManager, long id, UserDTO user)
        {
            _ordersManager = orderManager;
            _user = user;
            _id = id;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            _ordersManager.ChangeOrderStatus(_id, (short)btnOK.TabIndex, App.User_here.UserID);
        }
    }
}
