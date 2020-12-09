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
    public partial class MainForm : Form
    {
        protected readonly IOrdersManager _ordersManager;
        protected static UserDTO _user = Program.User_here;

        public MainForm(IOrdersManager ordersManager)
        {
            InitializeComponent();
            _ordersManager = ordersManager;            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void botton_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button_ManageOrders_Click(object sender, EventArgs e)
        {
            if (_user.AccessLevel > 5)
            {
                this.Hide();
                OrdersDetails ordersForm = new OrdersDetails(_ordersManager);
                ordersForm.Show();                
            }
            else
            {
                MessageBox.Show("You do not have access to this page!");
            }
        }
    }
}
