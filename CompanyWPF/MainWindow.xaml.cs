using BusinessLogic.Interfaces;
using DTO;
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
using CompanyWPF.Model;
using CompanyWPF.ViewModels;

namespace CompanyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IOrdersManager _orderManager;

        private OrderListViewModel _orderListView;
        public MainWindow(IOrdersManager orderManager)
        {
            _orderManager = orderManager;
            _orderListView = new OrderListViewModel(_orderManager);
            InitializeComponent();
        }

        private void btn_byUsername_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.Items.Refresh();
            var list = _orderManager.FindOrdersByUser(_orderManager.GetUserIdByUsername(txtB_byUsername.Text));
            dataGrid.ItemsSource = _orderListView.ToMyOrderList(list);
        }

        private void DefaultSortButton_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.Items.Refresh();
            dataGrid.ItemsSource = _orderListView.GetMyOrders(); 
        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DateSortButton_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.Items.Refresh();
            dataGrid.ItemsSource = _orderListView.ToMyOrderList(_orderManager.SortOrdersByLastUpdate());
        }

        private void StatusSortButton_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.Items.Refresh();
            dataGrid.ItemsSource = _orderListView.ToMyOrderList(_orderManager.SortOrdersByStatuses());
        }

        private void btn_byItem_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.Items.Refresh();
            var list = _orderManager.FindOrdersByItem(_orderManager.GetItemIdByIdTitle(txtB_byItem.Text));
            dataGrid.ItemsSource = _orderListView.ToMyOrderList(list);
        }
    }
}
