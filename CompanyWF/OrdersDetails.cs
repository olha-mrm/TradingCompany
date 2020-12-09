using BusinessLogic.Interfaces;
using DALEF.Concrete;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace CompanyWF
{
    public partial class OrdersDetails : Form
    {
        protected readonly IOrdersManager _ordersManager;
        public OrdersDetails(IOrdersManager _ordersManager)
        {
            InitializeComponent();
            this._ordersManager = _ordersManager;
        }

        
        private void button_goBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm(_ordersManager);
            mainForm.Show();
        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }
        private void FindOrdersByUser_Click(object sender, EventArgs e)
        {
            FindOrdersView.Items.Clear();
            var list = _ordersManager.FindOrdersByUser(_ordersManager.GetUserIdByUsername(textBox_byUsers.Text));

            foreach (var i in list)
            {
                string[] row = { i.MainOrderID.ToString(),
                    _ordersManager.GetUsersFullNameById(i.CustomerID),
                    i.Date.ToString(),
                    _ordersManager.GetStatusName(i.StatusID),
                    i.LastUpdate.ToString(),
                    _ordersManager.GetUsersFullNameById(i.LastStaffUpdated != null ? i.LastStaffUpdated.Value : 0),
                    i.Comments};
                var listViewItem = new ListViewItem(row);
                FindOrdersView.Items.Add(listViewItem);
            }

        }

        //private void ShowOrders()
        //{
        //    FindOrdersView.Clear();

        //}
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FindOrdersByItem_Click(object sender, EventArgs e)
        {
            FindOrdersView.Items.Clear();
            var list = _ordersManager.FindOrdersByItem(_ordersManager.GetItemIdByIdTitle(textBox_byItem.Text));

            foreach (var i in list)
            {
                string[] row = { i.MainOrderID.ToString(),
                    _ordersManager.GetUsersFullNameById(i.CustomerID),
                    i.Date.ToString(),
                    _ordersManager.GetStatusName(i.StatusID),
                    i.LastUpdate.ToString(),
                    _ordersManager.GetUsersFullNameById(i.LastStaffUpdated != null ? i.LastStaffUpdated.Value : 0),
                    i.Comments};
                var listViewItem = new ListViewItem(row);
                FindOrdersView.Items.Add(listViewItem);
            }
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            SortOrderView.Items.Clear();
            var list = _ordersManager.GetAllOrders();

            foreach (var i in list)
            {
                string[] row = { i.MainOrderID.ToString(),
                    _ordersManager.GetUsersFullNameById(i.CustomerID),
                    i.Date.ToString(),
                    _ordersManager.GetStatusName(i.StatusID),
                    i.LastUpdate.ToString(),
                    _ordersManager.GetUsersFullNameById(i.LastStaffUpdated != null ? i.LastStaffUpdated.Value : 0),
                    i.Comments};
                var listViewItem = new ListViewItem(row);
                SortOrderView.Items.Add(listViewItem);
            }
        }

        private void buttonSortByDate_Click(object sender, EventArgs e)
        {
            SortOrderView.Items.Clear();
            var list = _ordersManager.SortOrdersByLastUpdate();

            foreach (var i in list)
            {
                string[] row = { i.MainOrderID.ToString(),
                    _ordersManager.GetUsersFullNameById(i.CustomerID),
                    i.Date.ToString(),
                    _ordersManager.GetStatusName(i.StatusID),
                    i.LastUpdate.ToString(),
                    _ordersManager.GetUsersFullNameById(i.LastStaffUpdated != null ? i.LastStaffUpdated.Value : 0),
                    i.Comments};
                var listViewItem = new ListViewItem(row);
                SortOrderView.Items.Add(listViewItem);
            }
        }

        private void buttonSortByStatus_Click(object sender, EventArgs e)
        {
            SortOrderView.Items.Clear();
            var list = _ordersManager.SortOrdersByStatuses();

            foreach (var i in list)
            {
                string[] row = { i.MainOrderID.ToString(),
                    _ordersManager.GetUsersFullNameById(i.CustomerID),
                    i.Date.ToString(),
                    _ordersManager.GetStatusName(i.StatusID),
                    i.LastUpdate.ToString(),
                    _ordersManager.GetUsersFullNameById(i.LastStaffUpdated != null ? i.LastStaffUpdated.Value : 0),
                    i.Comments};
                var listViewItem = new ListViewItem(row);
                SortOrderView.Items.Add(listViewItem);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void orderText_Changed(object sender, EventArgs e)
        {
            listViewItems.Items.Clear();
            listViewOrder.Items.Clear();            
        }

        private void buttonFindOrder_Click(object sender, EventArgs e)
        {
            listViewItems.Items.Clear();
            listViewOrder.Items.Clear();

            OrderDTO order = new OrderDTO();
            try
            {
                order = _ordersManager.GetOrderById(Convert.ToInt64(textBox1.Text));
            }
            catch
            {
                MessageBox.Show("Incorrect data inputted!!!");
                textBox1.Text = "";
                return;
            }

            if (order is null)
                return;

            string[] row1 = { "Full Name: ", _ordersManager.GetUsersFullNameById(order.CustomerID) };            
            string[] row2 = { "Date: ", order.Date.ToString() };
            string[] row3 = { "Comments: ", order.Comments};
            
            string[] row1_ = { "Last Update: ", order.LastUpdate.ToString()};
            string[] row2_ = { "Last Update By", _ordersManager.GetUsersFullNameById(order.LastStaffUpdated != null ? order.LastStaffUpdated.Value : 0) };
            string[] row3_ = { "Status: ", _ordersManager.GetStatusName(order.StatusID) };

            listViewOrder.Items.Add(new ListViewItem(row1));
            listViewOrder.Items.Add(new ListViewItem(row2));
            listViewOrder.Items.Add(new ListViewItem(row3));

            listViewOrder.Items.Add(new ListViewItem(row3_));
            listViewOrder.Items.Add(new ListViewItem(row1_));
            listViewOrder.Items.Add(new ListViewItem(row2_));

            List<OrdersRefDTO> refs = _ordersManager.GetItemsInOrder(Convert.ToInt64(textBox1.Text));

            foreach (var i in refs)
            {
                string[] row = { _ordersManager.GetItemNameById(i.refItemID),
                i.refItemID.ToString(),
                _ordersManager.GetItemById(i.refItemID).Price.ToString(),
                i.amount.ToString()};

                listViewItems.Items.Add(new ListViewItem(row));
            }
        }

        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {

            OrderDTO order = new OrderDTO();
            try
            {
                order = _ordersManager.GetOrderById(Convert.ToInt64(textBox1.Text));
            }
            catch
            {
                MessageBox.Show("Incorrect order ID!!!");
                textBox1.Text = "";
                return;
            }
            if (order is null)
                return;
            if (comboBoxStatuses.SelectedIndex == -1)
            {
                MessageBox.Show("No Status Selected!");
                return;
            }

            
            _ordersManager.ChangeOrderStatus(order.MainOrderID, (short)comboBoxStatuses.SelectedIndex, Program.User_here.UserID);            
        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
